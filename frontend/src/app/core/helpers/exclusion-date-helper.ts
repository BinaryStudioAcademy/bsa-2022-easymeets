import { IExclusionTimeRange } from '@core/models/schedule/exclusion-date/IExclusionTimeRange';

export const sortExclusionTimeRanges = (ranges: IExclusionTimeRange[]) =>
    ranges.sort(
        (firstRange, secondRange) => new Date(firstRange.start).getTime() - new Date(secondRange.start).getTime(),
    );
