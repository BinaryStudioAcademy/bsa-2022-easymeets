import { IScheduleItem } from '@core/models/IScheduleItem';

export interface ISchedule {
    timeZone: number;
    scheduleItems: IScheduleItem[];
    withTeamMembers: boolean;
}
