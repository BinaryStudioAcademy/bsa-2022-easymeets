import { IDayTimeRange } from '@core/models/schedule/exclusion-date/IDayTimeRange';

export interface IExclusionDate {
    selectedDate: string;
    dayTimeRanges: IDayTimeRange[];
}
