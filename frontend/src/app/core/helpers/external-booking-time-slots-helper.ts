import { IDayTimeSlot } from '@core/models/IDayTimeSlot';

export const getExternalBookingTimeSlotsItems = (): IDayTimeSlot[] => [
    {
        dayOfWeek: 'MON',
        startTime: new Date(new Date().setHours(9, 0, 0, 0)),
        finishTime: new Date(new Date().setHours(17, 0, 0, 0)),
    },
    {
        dayOfWeek: 'TUE',
        startTime: new Date(new Date().setHours(7, 0, 0, 0)),
        finishTime: new Date(new Date().setHours(18, 0, 0, 0)),
    },
    {
        dayOfWeek: 'WED',
        startTime: new Date(new Date().setHours(9, 0, 0, 0)),
        finishTime: new Date(new Date().setHours(17, 0, 0, 0)),
    },
    {
        dayOfWeek: 'THU',
        startTime: new Date(new Date().setHours(8, 0, 0, 0)),
        finishTime: new Date(new Date().setHours(19, 0, 0, 0)),
    },
    {
        dayOfWeek: 'FRI',
        startTime: new Date(new Date().setHours(9, 0, 0, 0)),
        finishTime: new Date(new Date().setHours(17, 0, 0, 0)),
    },
    {
        dayOfWeek: 'SAT',
        startTime: new Date(new Date().setHours(9, 0, 0, 0)),
        finishTime: new Date(new Date().setHours(12, 0, 0, 0)),
    },
];
