import { IExclusionTimeRange } from '@core/models/schedule/exclusion-date/IExclusionTimeRange';

export interface IExclusionTimeRangesDisplay {
    connectedExclusionTimeRanges: IExclusionTimeRange[];
    date: string;
}
