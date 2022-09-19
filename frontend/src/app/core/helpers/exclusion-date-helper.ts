import { DateAdapter } from '@angular/material/core';
import { DayAction } from '@core/enums/day-action.enum';
import { FindSameExclusionDateHelper } from '@core/helpers/find-same-exclusion-date-helper';
import { convertTimeToOffset, getTimeString } from '@core/helpers/time-helper';
import { TimeRangesMergeHelper } from '@core/helpers/time-ranges-merge-helper';
import { getDateStringWithoutLocalOffset } from '@core/helpers/time-zone-helper';
import { IDayTimeRange } from '@core/models/schedule/exclusion-date/IDayTimeRange';
import { IExclusionDate } from '@core/models/schedule/exclusion-date/IExclusionDate';

export const getExclusionDate = (
    selected: string,
    startHours: number,
    startMinutes: string,
    endHours: number,
    endMinutes: string,
): IExclusionDate => ({
    selectedDate: selected,
    dayTimeRanges: [
        {
            start: getTimeString(startHours, startMinutes),
            end: getTimeString(endHours, endMinutes),
        },
    ],
});

export function getExclusionDateWithDayOffset(
    exclusionDate: IExclusionDate,
    dateAdapter: DateAdapter<Date>,
    startHours: number,
    startMinutes: string,
    endHours: number,
    endMinutes: string,
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

    return [
        getExclusionDate(
            getDateStringWithoutLocalOffset(convertedDate),
            startHours,
            startMinutes,
            endHours,
            endMinutes,
        ),
    ];
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
            const [startHours, startMinutes, startHoursDayAction] = convertTimeToOffset(
                dayTimeRange.start,
                timeZoneValue,
            );
            const [endHours, endMinutes, endHoursDayAction] = convertTimeToOffset(
                dayTimeRange.end === '23:59' && !timeZoneValue.includes('00:00') ? '24:00' : dayTimeRange.end,
                timeZoneValue,
            );

            if (startHoursDayAction === endHoursDayAction) {
                return getExclusionDateWithDayOffset(
                    exclusionDate,
                    dateAdapter,
                    startHours,
                    startMinutes,
                    endHours,
                    endMinutes,
                    startHoursDayAction,
                );
            }

            const [startRangeDate, endRangeDate] = getConvertedDatesForExclusionDate(
                exclusionDate,
                dateAdapter,
                startHoursDayAction,
            );

            if (endHours === 0 && endMinutes === '00') {
                return [getExclusionDate(startRangeDate, startHours, startMinutes, 23, '59')];
            }

            return [
                getExclusionDate(startRangeDate, startHours, startMinutes, 23, '59'),
                getExclusionDate(endRangeDate, 0, '00', endHours, endMinutes),
            ];
        })
        .flat();

export const sortDayTimeRanges = (ranges: IDayTimeRange[]) =>
    ranges.sort((firstRange, secondRange) => firstRange.start.localeCompare(secondRange.start));

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
