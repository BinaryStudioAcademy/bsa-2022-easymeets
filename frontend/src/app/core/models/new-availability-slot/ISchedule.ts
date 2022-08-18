import { IScheduleItem } from '@core/models/new-availability-slot/IScheduleItem';

export interface ISchedule {
    timeZone: number;
    items: IScheduleItem[];
    withTeamMembers: boolean;
}
