import { sortExclusionTimeRanges } from '@core/helpers/exclusion-date-helper';
import { IExclusionTimeRange } from '@core/models/schedule/exclusion-date/IExclusionTimeRange';
import * as moment from 'moment-timezone';

export const ExclusionTimeRangesMergeHelper = (ranges: IExclusionTimeRange[]) => {
    sortExclusionTimeRanges(ranges);
    let currentTimeRange = ranges.shift();
    let mergedExclusionRanges: IExclusionTimeRange[] = [];

    while (currentTimeRange) {
        const rangeToMerge = ranges.shift();

        const currentStartDate = moment.utc(currentTimeRange.start).toDate();
        const currentEndDate = moment.utc(currentTimeRange.end).toDate();

        if (!rangeToMerge || moment.utc(rangeToMerge.start).toDate() > currentStartDate) {
            mergedExclusionRanges = [...mergedExclusionRanges, currentTimeRange];
            currentTimeRange = rangeToMerge;
        } else if (
            moment.utc(rangeToMerge.start).toDate() <= currentEndDate &&
            moment.utc(rangeToMerge.end).toDate() > currentEndDate
        ) {
            currentTimeRange.end = rangeToMerge.end;
        }
    }

    return mergedExclusionRanges;
};
