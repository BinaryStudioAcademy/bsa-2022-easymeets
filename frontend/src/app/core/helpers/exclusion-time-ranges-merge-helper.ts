import { sortExclusionTimeRanges } from '@core/helpers/exclusion-date-helper';
import { IExclusionTimeRange } from '@core/models/schedule/exclusion-date/IExclusionTimeRange';

export const ExclusionTimeRangesMergeHelper = (ranges: IExclusionTimeRange[]) => {
    sortExclusionTimeRanges(ranges);
    let currentTimeRange = ranges.shift();
    let mergedExclusionRanges: IExclusionTimeRange[] = [];

    while (currentTimeRange) {
        const rangeToMerge = ranges.shift();

        if (!rangeToMerge || new Date(rangeToMerge.start) > new Date(currentTimeRange.end)) {
            mergedExclusionRanges = [...mergedExclusionRanges, currentTimeRange];
            currentTimeRange = rangeToMerge;
        } else if (
            new Date(rangeToMerge.start) <= new Date(currentTimeRange.end) &&
            new Date(rangeToMerge.end) > new Date(currentTimeRange.end)
        ) {
            currentTimeRange.end = rangeToMerge.end;
        }
    }

    return mergedExclusionRanges;
};
