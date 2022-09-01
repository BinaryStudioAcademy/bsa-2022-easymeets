import { IScheduleItem } from '@core/models/schedule/IScheduleItem';

export interface ISchedule {
    timeZone: number;
    scheduleItems: IScheduleItem[];
    withTeamMembers: boolean;
    definedExternally: boolean;
    definedBy?: string;
}
