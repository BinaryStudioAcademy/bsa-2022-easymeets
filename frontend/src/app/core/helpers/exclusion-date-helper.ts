import { getMillisecondsFromDateString } from '@core/helpers/time-helper';
import { IExclusionTimeRange } from '@core/models/schedule/exclusion-date/IExclusionTimeRange';

export const sortExclusionTimeRanges = (ranges: IExclusionTimeRange[]) =>
    ranges.sort(
        (firstRange, secondRange) =>
            getMillisecondsFromDateString(firstRange.start) - getMillisecondsFromDateString(secondRange.start),
    );

export const findExclusionTimeRange = (
    exclusionTimeRangeToFind: IExclusionTimeRange,
    exclusionTimeRanges: IExclusionTimeRange[],
) =>
    exclusionTimeRanges.find(
        (range) =>
            getMillisecondsFromDateString(exclusionTimeRangeToFind.start) ===
                getMillisecondsFromDateString(range.start) &&
            getMillisecondsFromDateString(exclusionTimeRangeToFind.end) === getMillisecondsFromDateString(range.end),
    );
