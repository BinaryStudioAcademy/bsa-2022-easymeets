import { IScheduleItem } from '@core/models/schedule/IScheduleItem';
import { IScheduleItemReceive } from '@core/models/schedule/IScheduleItemsReceive';
import { ITimeSpan } from '@core/models/schedule/ITimeSpan';
import { addHours, addMinutes } from 'date-fns';

export const timeSpanToString = (value: ITimeSpan): string => {
    const hour = value.hour < 10 ? `0${value.hour}` : value.hour.toString(10);
    const minute = value.minute < 10 ? `0${value.minute}` : value.minute.toString(10);

    return `${hour}:${minute}`;
};

export const stringToTimeSpan = (value: string): ITimeSpan => {
    const arr = value.split(':');

    return { hour: parseInt(arr[0], 10), minute: parseInt(arr[1], 10) };
};

export const dateToTimeSpan = (value: Date): ITimeSpan => ({ hour: value.getHours(), minute: value.getMinutes() });

export const compareTimeSpan = (lessValue: ITimeSpan, biggerValue: ITimeSpan): boolean =>
    lessValue.hour * 60 + lessValue.minute < biggerValue.hour * 60 + biggerValue.minute;

export const changeScheduleItemsDate = (items: IScheduleItem[]): IScheduleItemReceive[] =>
    items.map((el) => ({
        ...el,
        start: addMinutes(addHours(new Date(), el.start.hour), el.start.minute),
        end: addMinutes(addHours(new Date(), el.end.hour), el.end.minute),
    }));
