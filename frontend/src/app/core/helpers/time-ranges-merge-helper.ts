import { IDayTimeRange } from '@core/models/schedule/exclusion-date/IDayTimeRange';

export const TimeRangesMergeHelper = (ranges: IDayTimeRange[]) => {
    const mergedExclusionDates: IDayTimeRange[] = [];
    let currentDate = ranges.shift();

    while (currentDate) {
        let allFurtherDatesMerged = false;

        let dateToMerge = ranges.shift();

        while (!allFurtherDatesMerged && dateToMerge) {
            if (dateToMerge.start <= currentDate.end && dateToMerge.end > currentDate.end) {
                currentDate.end = dateToMerge.end;
                dateToMerge = ranges.shift();
            } else if (dateToMerge.start > currentDate.end) {
                allFurtherDatesMerged = true;
                ranges.unshift(dateToMerge);
            } else {
                dateToMerge = ranges.shift();
            }
        }
        mergedExclusionDates.push(currentDate);
        currentDate = ranges.shift();
    }

    return mergedExclusionDates;
};
