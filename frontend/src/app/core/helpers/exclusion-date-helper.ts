import { DateAdapter } from '@angular/material/core';
import { DayAction } from '@core/enums/day-action.enum';
import { FindSameExclusionDateHelper } from '@core/helpers/find-same-exclusion-date-helper';
import { convertTimeToOffset } from '@core/helpers/time-helper';
import { TimeRangesMergeHelper } from '@core/helpers/time-ranges-merge-helper';
import { getDateStringWithoutLocalOffset } from '@core/helpers/time-zone-helper';
import { ITimeOnly } from '@core/models/ITimeOnly';
import { IDayTimeRange } from '@core/models/schedule/exclusion-date/IDayTimeRange';
import { IExclusionDate } from '@core/models/schedule/exclusion-date/IExclusionDate';

export const getExclusionDate = (selected: string, start: ITimeOnly, end: ITimeOnly): IExclusionDate => ({
    selectedDate: selected,
    dayTimeRanges: [
        {
            start,
            end,
        },
    ],
});

export function getExclusionDateWithDayOffset(
    exclusionDate: IExclusionDate,
    dateAdapter: DateAdapter<Date>,
    start: ITimeOnly,
    end: ITimeOnly,
    dayAction: DayAction,
) {
    let convertedDate: Date;

    switch (dayAction) {
        case DayAction.AddDay: {
            convertedDate = dateAdapter.addCalendarDays(new Date(exclusionDate.selectedDate), 1);
            break;
        }
        case DayAction.SubtractDay: {
            convertedDate = dateAdapter.addCalendarDays(new Date(exclusionDate.selectedDate), -1);
            break;
        }
        default: {
            convertedDate = new Date(exclusionDate.selectedDate);
        }
    }

    return [getExclusionDate(getDateStringWithoutLocalOffset(convertedDate), start, end)];
}

export const getConvertedDatesForExclusionDate = (
    exclusionDate: IExclusionDate,
    dateAdapter: DateAdapter<Date>,
    startHoursDayAction: DayAction,
): [string, string] =>
    (startHoursDayAction === DayAction.SubtractDay
        ? [
            getDateStringWithoutLocalOffset(dateAdapter.addCalendarDays(new Date(exclusionDate.selectedDate), -1)),
            exclusionDate.selectedDate,
        ]
        : [
            exclusionDate.selectedDate,
            getDateStringWithoutLocalOffset(dateAdapter.addCalendarDays(new Date(exclusionDate.selectedDate), 1)),
        ]);

export const convertExclusionDateToOffset = (
    exclusionDate: IExclusionDate,
    timeZoneValue: string,
    dateAdapter: DateAdapter<Date>,
): IExclusionDate[] =>
    exclusionDate.dayTimeRanges
        .map((dayTimeRange) => {
            const [start, startHoursDayAction] = convertTimeToOffset(dayTimeRange.start, timeZoneValue);
            const [end, endHoursDayAction] = convertTimeToOffset(
                dayTimeRange.end.hour === 23 && dayTimeRange.end.minute === 59 && !timeZoneValue.includes('00:00')
                    ? { hour: 24, minute: 0 }
                    : dayTimeRange.end,
                timeZoneValue,
            );

            if (startHoursDayAction === endHoursDayAction) {
                return getExclusionDateWithDayOffset(exclusionDate, dateAdapter, start, end, startHoursDayAction);
            }

            const [startRangeDate, endRangeDate] = getConvertedDatesForExclusionDate(
                exclusionDate,
                dateAdapter,
                startHoursDayAction,
            );

            if (end.hour === 0 && end.minute === 0) {
                return [getExclusionDate(startRangeDate, start, { hour: 23, minute: 59 })];
            }

            return [
                getExclusionDate(startRangeDate, start, { hour: 23, minute: 59 }),
                getExclusionDate(endRangeDate, { hour: 0, minute: 0 }, end),
            ];
        })
        .flat();

export const sortDayTimeRanges = (ranges: IDayTimeRange[]) =>
    ranges.sort(
        (firstRange, secondRange) =>
            firstRange.start.hour * 60 +
            firstRange.start.minute -
            (secondRange.start.hour * 60 + secondRange.start.minute),
    );

export function mergeExistingExclusionDates(newExclusionDate: IExclusionDate, exclusionDates: IExclusionDate[]) {
    const sameDate = FindSameExclusionDateHelper(exclusionDates, newExclusionDate);

    if (sameDate) {
        sameDate.dayTimeRanges = sortDayTimeRanges([...sameDate.dayTimeRanges, ...newExclusionDate.dayTimeRanges]);
        sameDate.dayTimeRanges = TimeRangesMergeHelper(sameDate.dayTimeRanges);

        return true;
    }

    return false;
}

export function getUpdatedExclusionDatesDisplay(
    exclusionDates: IExclusionDate[],
    timeZoneValue: string,
    dateAdapter: DateAdapter<Date>,
) {
    let updatedExclusionDatesDisplay: IExclusionDate[] = [];

    exclusionDates.forEach((exclusionDate) => {
        const convertedExclusionDates = convertExclusionDateToOffset(exclusionDate, timeZoneValue, dateAdapter);

        convertedExclusionDates.forEach((convertedExclusionDate) => {
            if (!mergeExistingExclusionDates(convertedExclusionDate, updatedExclusionDatesDisplay)) {
                updatedExclusionDatesDisplay = [...updatedExclusionDatesDisplay, convertedExclusionDate];
            }
        });
    });

    return updatedExclusionDatesDisplay;
}
