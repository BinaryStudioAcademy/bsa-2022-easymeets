import { sortExclusionTimeRanges } from '@core/helpers/exclusion-date-helper';
import { IExclusionTimeRange } from '@core/models/schedule/exclusion-date/IExclusionTimeRange';
import * as moment from 'moment-timezone';

export const ExclusionTimeRangesMergeHelper = (ranges: IExclusionTimeRange[]) => {
    sortExclusionTimeRanges(ranges);
    let currentTimeRange = ranges.shift();
    let mergedExclusionRanges: IExclusionTimeRange[] = [];
    while (currentTimeRange) {
        const rangeToMerge = ranges.shift();

        if (!rangeToMerge || moment.utc(rangeToMerge.start).toDate() > moment.utc(currentTimeRange.end).toDate()) {
            mergedExclusionRanges = [...mergedExclusionRanges, currentTimeRange];
            currentTimeRange = rangeToMerge;
        } else if (
            moment.utc(rangeToMerge.start).toDate() <= moment.utc(currentTimeRange.end).toDate() &&
            moment.utc(rangeToMerge.end).toDate() > moment.utc(currentTimeRange.end).toDate()
        ) {
            currentTimeRange.end = rangeToMerge.end;
        }
    }

    return mergedExclusionRanges;
};
