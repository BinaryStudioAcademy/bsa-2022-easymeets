import { IDayTimeRange } from '@core/models/schedule/exclusion-date/IDayTimeRange';

export const TimeRangesMergeHelper = (ranges: IDayTimeRange[]) => {
    const mergedExclusionDates: IDayTimeRange[] = [];
    let currentDate = ranges.shift();

    while (currentDate) {
        const dateToMerge = ranges.shift();

        if (!dateToMerge || (dateToMerge.start > currentDate.end)) {
            mergedExclusionDates.push(currentDate);
            currentDate = dateToMerge;
        } else if (dateToMerge.start <= currentDate.end && dateToMerge.end > currentDate.end) {
            currentDate.end = dateToMerge.end;
        }
    }

    return mergedExclusionDates;
};
