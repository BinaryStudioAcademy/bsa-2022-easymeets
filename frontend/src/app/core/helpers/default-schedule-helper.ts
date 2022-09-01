import { getScheduleItems } from '@core/helpers/schedule-list-helper';
import { ISchedule } from '@core/models/schedule/ISchedule';

export const getDefaultSchedule = (externallyDefined: boolean): ISchedule => ({
    timeZoneName: 'Europe/Kiev (+03:00)',
    timeZoneValue: '',
    withTeamMembers: false,
    scheduleItems: externallyDefined ? [] : getScheduleItems(),
    definedExternally: externallyDefined,
    definedBy: undefined,
});
