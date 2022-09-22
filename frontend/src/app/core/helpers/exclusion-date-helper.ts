import { IExclusionTimeRange } from '@core/models/schedule/exclusion-date/IExclusionTimeRange';
import * as moment from 'moment-timezone';

export const sortExclusionTimeRanges = (ranges: IExclusionTimeRange[]) =>
    ranges.sort(
        (firstRange, secondRange) =>
            moment.utc(firstRange.start).toDate().getTime() - moment.utc(secondRange.start).toDate().getTime(),
    );

export const findExclusionTimeRange = (
    exclusionTimeRangeToFind: IExclusionTimeRange,
    exclusionTimeRanges: IExclusionTimeRange[],
) =>
    exclusionTimeRanges.find(
        (range) =>
            moment.utc(exclusionTimeRangeToFind.start).toDate().getTime() ===
                moment.utc(range.start).toDate().getTime() &&
            moment.utc(exclusionTimeRangeToFind.end).toDate().getTime() === moment.utc(range.end).toDate().getTime(),
    );
