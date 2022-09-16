import { DateAdapter } from '@angular/material/core';
import { DayAction } from '@core/enums/day-action.enum';
import { FindSameExclusionDateHelper } from '@core/helpers/find-same-exclusion-date-helper';
import { convertTimeToOffset, getTimeString, normalizeHours } from '@core/helpers/time-helper';
import { TimeRangesMergeHelper } from '@core/helpers/time-ranges-merge-helper';
import { getDateWithoutLocalOffset } from '@core/helpers/time-zone-helper';
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

export const convertExclusionDateToOffset = (
    exclusionDate: IExclusionDate,
    timeZoneValue: string,
    dateAdapter: DateAdapter<Date>,
): IExclusionDate[] =>
    exclusionDate.dayTimeRanges
        .map((dayTimeRange) => {
            const [startHours, startMinutes] = convertTimeToOffset(dayTimeRange.start, timeZoneValue);
            const [endHours, endMinutes] = convertTimeToOffset(
                dayTimeRange.end === '23:59' && !timeZoneValue.includes('00:00') ? '24:00' : dayTimeRange.end,
                timeZoneValue,
            );

            const [normalizedStartHours, startHoursDayAction] = normalizeHours(startHours);
            const [normalizedEndHours, endHoursDayAction] = normalizeHours(endHours);

            let correctDate: Date;

            if (startHoursDayAction === endHoursDayAction) {
                if (startHoursDayAction === DayAction.AddDay) {
                    correctDate = dateAdapter.addCalendarDays(new Date(exclusionDate.selectedDate), 1);
                } else if (startHoursDayAction === DayAction.SubtractDay) {
                    correctDate = dateAdapter.addCalendarDays(new Date(exclusionDate.selectedDate), -1);
                } else {
                    correctDate = new Date(exclusionDate.selectedDate);
                }

                return [
                    getExclusionDate(
                        getDateWithoutLocalOffset(correctDate).toJSON(),
                        normalizedStartHours,
                        startMinutes,
                        normalizedEndHours,
                        endMinutes,
                    ),
                ];
            }

            const [startRangeDate, endRangeDate] =
                startHoursDayAction === DayAction.SubtractDay
                    ? [
                        getDateWithoutLocalOffset(
                            dateAdapter.addCalendarDays(new Date(exclusionDate.selectedDate), -1),
                        ).toJSON(),
                        exclusionDate.selectedDate,
                    ]
                    : [
                        exclusionDate.selectedDate,
                        getDateWithoutLocalOffset(
                            dateAdapter.addCalendarDays(new Date(exclusionDate.selectedDate), 1),
                        ).toJSON(),
                    ];

            if (normalizedEndHours === 0 && endMinutes === '00') {
                return [getExclusionDate(startRangeDate, normalizedStartHours, startMinutes, 23, '59')];
            }

            return [
                getExclusionDate(startRangeDate, normalizedStartHours, startMinutes, 23, '59'),
                getExclusionDate(endRangeDate, 0, '00', normalizedEndHours, endMinutes),
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
