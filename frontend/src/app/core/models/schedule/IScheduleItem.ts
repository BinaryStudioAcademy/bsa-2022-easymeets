import { WeekDay } from '@shared/enums/weekDay';

export interface IScheduleItem {
    start: string;
    end: string;
    weekDay: WeekDay;
    isEnabled: boolean;
}
