import { IScheduleItem } from '@core/models/schedule/IScheduleItem';
import { WeekDay } from '@shared/enums/weekDay';

export const getScheduleItems = (): IScheduleItem[] => [
    {
        start: { hour: 13, minute: 0 },
        end: { hour: 15, minute: 0 },
        weekDay: WeekDay.Sunday,
        isEnabled: false,
    },
    {
        start: { hour: 13, minute: 0 },
        end: { hour: 15, minute: 0 },
        weekDay: WeekDay.Monday,
        isEnabled: true,
    },
    {
        start: { hour: 13, minute: 0 },
        end: { hour: 15, minute: 0 },
        weekDay: WeekDay.Tuesday,
        isEnabled: true,
    },
    {
        start: { hour: 13, minute: 0 },
        end: { hour: 15, minute: 0 },
        weekDay: WeekDay.Wednesday,
        isEnabled: true,
    },
    {
        start: { hour: 13, minute: 0 },
        end: { hour: 15, minute: 0 },
        weekDay: WeekDay.Thursday,
        isEnabled: true,
    },
    {
        start: { hour: 13, minute: 0 },
        end: { hour: 15, minute: 0 },
        weekDay: WeekDay.Friday,
        isEnabled: true,
    },
    {
        start: { hour: 13, minute: 0 },
        end: { hour: 15, minute: 0 },
        weekDay: WeekDay.Saturday,
        isEnabled: false,
    },
];
