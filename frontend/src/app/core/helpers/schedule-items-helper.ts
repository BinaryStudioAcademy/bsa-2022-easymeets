import { IScheduleItem } from '@core/models/schedule/IScheduleItem';
import { IScheduleItemReceive } from '@core/models/schedule/IScheduleItemsReceive';

export const parseTimeSpan = (value: string): Date => {
    const arr = value.split(':');
    const date = new Date();

    date.setHours(Number(arr[0]));
    date.setMinutes(Number(arr[1]));

    return date;
};

export const changeScheduleItemsDate = (items: IScheduleItem[]): IScheduleItemReceive[] =>
    items.map((el) => ({
        ...el,
        start: parseTimeSpan(el.start.toString()),
        end: parseTimeSpan(el.end.toString()),
    }));
