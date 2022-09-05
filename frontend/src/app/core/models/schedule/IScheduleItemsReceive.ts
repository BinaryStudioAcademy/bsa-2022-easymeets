import { WeekDay } from '@shared/enums/weekDay';

export interface IScheduleItemReceive {
    id?: bigint;
    start: Date;
    end: Date;
    weekDay: WeekDay;
    isEnabled: boolean;
}
