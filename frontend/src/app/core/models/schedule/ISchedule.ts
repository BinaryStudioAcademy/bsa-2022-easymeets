import { IExclusionDate } from '@core/models/schedule/exclusion-date/IExclusionDate';
import { IScheduleItem } from '@core/models/schedule/IScheduleItem';

import { ITimeZone } from '../ITimeZone';

export interface ISchedule {
    timeZone: ITimeZone;
    scheduleItems: IScheduleItem[];
    exclusionDates: IExclusionDate[];
    withTeamMembers: boolean;
    definedExternally: boolean;
    definedBy?: string;
}
