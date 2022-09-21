import { IExclusionTimeRange } from '@core/models/schedule/exclusion-date/IExclusionTimeRange';
import { IScheduleItem } from '@core/models/schedule/IScheduleItem';

import { ITimeZone } from '../ITimeZone';

export interface ISchedule {
    timeZone: ITimeZone;
    scheduleItems: IScheduleItem[];
    exclusionTimeRanges: IExclusionTimeRange[];
    withTeamMembers: boolean;
    definedExternally: boolean;
    definedBy?: string;
}
