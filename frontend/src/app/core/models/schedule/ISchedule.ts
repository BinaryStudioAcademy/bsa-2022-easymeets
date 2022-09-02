import { IScheduleItem } from '@core/models/schedule/IScheduleItem';

import { ITimeZone } from '../ITimeZone';

export interface ISchedule {
    timeZone: ITimeZone;
    scheduleItems: IScheduleItem[];
    withTeamMembers: boolean;
    definedExternally: boolean;
    definedBy?: string;
}
