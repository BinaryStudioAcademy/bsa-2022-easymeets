import { IScheduleItem } from '@core/models/schedule/IScheduleItem';
import { WeekDay } from '@shared/enums/weekDay';

export const getScheduleItems = (): IScheduleItem[] => [
    {
        start: '13:00:00',
        end: '15:00:00',
        weekDay: WeekDay.Sunday,
        isEnabled: false,
    },
    {
        start: '13:00:00',
        end: '15:00:00',
        weekDay: WeekDay.Monday,
        isEnabled: true,
    },
    {
        start: '13:00:00',
        end: '15:00:00',
        weekDay: WeekDay.Tuesday,
        isEnabled: true,
    },
    {
        start: '13:00:00',
        end: '15:00:00',
        weekDay: WeekDay.Wednesday,
        isEnabled: true,
    },
    {
        start: '13:00:00',
        end: '15:00:00',
        weekDay: WeekDay.Thursday,
        isEnabled: true,
    },
    {
        start: '13:00:00',
        end: '15:00:00',
        weekDay: WeekDay.Friday,
        isEnabled: true,
    },
    {
        start: '13:00:00',
        end: '15:00:00',
        weekDay: WeekDay.Saturday,
        isEnabled: false,
    },
];
