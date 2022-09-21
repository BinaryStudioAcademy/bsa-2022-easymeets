import { ITimeSpan } from '@core/models/schedule/ITimeSpan';
import { WeekDay } from '@shared/enums/weekDay';

export interface IScheduleItem {
    id?: bigint;
    start: ITimeSpan;
    end: ITimeSpan;
    weekDay: WeekDay;
    isEnabled: boolean;
}
