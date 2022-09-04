import { getScheduleItems } from '@core/helpers/schedule-list-helper';
import { ISchedule } from '@core/models/schedule/ISchedule';

export const getDefaultSchedule = (externallyDefined: boolean): ISchedule => ({
    timeZone: 0,
    withTeamMembers: false,
    scheduleItems: externallyDefined ? [] : getScheduleItems(),
    exclusionDates: [],
    definedExternally: externallyDefined,
    definedBy: undefined,
});
