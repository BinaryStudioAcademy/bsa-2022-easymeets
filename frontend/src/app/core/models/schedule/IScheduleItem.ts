import { WeekDay } from '@shared/enums/weekDay';

export interface IScheduleItem {
    id?: bigint;
    start: string;
    end: string;
    weekDay: WeekDay;
    isEnabled: boolean;
}
