import { IScheduleItem } from '@core/models/schedule/IScheduleItem';

export interface ISchedule {
    timeZoneValue: string;
    timeZoneName: string;
    scheduleItems: IScheduleItem[];
    withTeamMembers: boolean;
    definedExternally: boolean;
    definedBy?: string;
}
