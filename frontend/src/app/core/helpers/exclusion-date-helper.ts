import { IExclusionTimeRange } from '@core/models/schedule/exclusion-date/IExclusionTimeRange';
import * as moment from 'moment-timezone';

export const sortExclusionTimeRanges = (ranges: IExclusionTimeRange[]) =>
    ranges.sort(
        (firstRange, secondRange) => moment.utc(firstRange.start).toDate().getTime() - moment.utc(secondRange.start).toDate().getTime(),
    );
