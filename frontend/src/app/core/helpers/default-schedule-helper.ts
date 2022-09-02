import { getScheduleItems } from '@core/helpers/schedule-list-helper';
import { ISchedule } from '@core/models/schedule/ISchedule';

export const getDefaultSchedule = (externallyDefined: boolean): ISchedule => ({
    timeZone: { nameValue: '', timeValue: '' },
    withTeamMembers: false,
    scheduleItems: externallyDefined ? [] : getScheduleItems(),
    definedExternally: externallyDefined,
    definedBy: undefined,
});
