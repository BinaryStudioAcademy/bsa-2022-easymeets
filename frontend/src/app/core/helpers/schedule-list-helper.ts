import { IScheduleItem } from '@core/models/IScheduleItem';

export const getScheduleItems = (): IScheduleItem[] => [
    {
        start: new Date(2022, 1, 1, 13, 0),
        end: new Date(2022, 1, 1, 15, 0),
        weekDay: 6,
        isEnabled: false,
    },
    {
        start: new Date(2022, 1, 1, 13, 0),
        end: new Date(2022, 1, 1, 15, 0),
        weekDay: 0,
        isEnabled: true,
    },
    {
        start: new Date(2022, 1, 1, 13, 0),
        end: new Date(2022, 1, 1, 15, 0),
        weekDay: 1,
        isEnabled: true,
    },
    {
        start: new Date(2022, 1, 1, 13, 0),
        end: new Date(2022, 1, 1, 15, 0),
        weekDay: 2,
        isEnabled: true,
    },
    {
        start: new Date(2022, 1, 1, 13, 0),
        end: new Date(2022, 1, 1, 15, 0),
        weekDay: 3,
        isEnabled: true,
    },
    {
        start: new Date(2022, 1, 1, 13, 0),
        end: new Date(2022, 1, 1, 15, 0),
        weekDay: 4,
        isEnabled: true,
    },
    {
        start: new Date(2022, 1, 1, 13, 0),
        end: new Date(2022, 1, 1, 15, 0),
        weekDay: 5,
        isEnabled: false,
    },
];
