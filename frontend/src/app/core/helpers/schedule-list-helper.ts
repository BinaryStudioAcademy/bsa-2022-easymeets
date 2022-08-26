import { IScheduleItem } from '@core/models/schedule/IScheduleItem';

export const getScheduleItems = (): IScheduleItem[] => [
    {
        start: '13:00:00',
        end: '15:00:00',
        weekDay: 0,
        isEnabled: true,
    },
    {
        start: '13:00:00',
        end: '15:00:00',
        weekDay: 1,
        isEnabled: true,
    },
    {
        start: '13:00:00',
        end: '15:00:00',
        weekDay: 2,
        isEnabled: true,
    },
    {
        start: '13:00:00',
        end: '15:00:00',
        weekDay: 3,
        isEnabled: true,
    },
    {
        start: '13:00:00',
        end: '15:00:00',
        weekDay: 4,
        isEnabled: true,
    },
    {
        start: '13:00:00',
        end: '15:00:00',
        weekDay: 5,
        isEnabled: false,
    },
    {
        start: '13:00:00',
        end: '15:00:00',
        weekDay: 6,
        isEnabled: false,
    },
];
