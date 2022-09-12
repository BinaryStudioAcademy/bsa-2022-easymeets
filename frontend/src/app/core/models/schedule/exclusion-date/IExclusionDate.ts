import { IDayTimeRange } from '@core/models/schedule/exclusion-date/IDayTimeRange';

export interface IExclusionDate {
    selectedDate: Date;
    dayTimeRanges: IDayTimeRange[];
}
