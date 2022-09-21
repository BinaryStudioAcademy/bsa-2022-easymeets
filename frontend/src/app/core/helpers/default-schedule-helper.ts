import { getScheduleItems } from '@core/helpers/schedule-list-helper';
import { ISchedule } from '@core/models/schedule/ISchedule';

import { getDefaultTimeZone } from './time-zone-helper';

export const getDefaultSchedule = (externallyDefined: boolean): ISchedule => ({
    timeZone: getDefaultTimeZone(),
    withTeamMembers: false,
    scheduleItems: externallyDefined ? [] : getScheduleItems(),
    exclusionTimeRanges: [],
    definedExternally: externallyDefined,
    definedBy: undefined,
});
