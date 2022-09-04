import { IExclusionDate } from '@core/models/schedule/exclusion-date/IExclusionDate';
import { IScheduleItem } from '@core/models/schedule/IScheduleItem';

export interface ISchedule {
    timeZone: number;
    scheduleItems: IScheduleItem[];
    exclusionDates: IExclusionDate[];
    withTeamMembers: boolean;
    definedExternally: boolean;
    definedBy?: string;
}
