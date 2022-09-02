import { IScheduleItemReceive } from '@core/models/schedule/IScheduleItemsReceive';

export const parseTimeSpan = (value: string): Date => {
    const arr = value.split(':');

    return new Date(new Date().setHours(parseInt(arr[0], 10), parseInt(arr[1], 10), parseInt(arr[2], 10), 0));
};

export const changeScheduleItemsDate = (items: IScheduleItemReceive[]): IScheduleItemReceive[] => {
    const newArray = items.map((el) => {
        const newStart = parseTimeSpan(el.start.toString());
        const newEnd = parseTimeSpan(el.end.toString());

        el.start = newStart;
        el.end = newEnd;

        return el;
    });

    return newArray;
};
