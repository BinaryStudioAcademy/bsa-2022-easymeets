import { IScheduleItem } from '@core/models/schedule/IScheduleItem';
import { IScheduleItemReceive } from '@core/models/schedule/IScheduleItemsReceive';

export const parseTimeSpan = (value: string): Date => {
    const arr = value.split(':');

    return new Date(new Date().setHours(parseInt(arr[0], 10), parseInt(arr[1], 10), parseInt(arr[2], 10), 0));
};

export const changeScheduleItemsDate = (items: IScheduleItem[]): IScheduleItemReceive[] =>
    items.map((el) => ({
        ...el,
        start: parseTimeSpan(el.start.toString()),
        end: parseTimeSpan(el.end.toString()),
    }));
