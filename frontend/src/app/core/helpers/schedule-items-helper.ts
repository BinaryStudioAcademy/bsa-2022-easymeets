import { IScheduleItem } from '@core/models/schedule/IScheduleItem';
import { IScheduleItemReceive } from '@core/models/schedule/IScheduleItemsReceive';
import { ITimeSpan } from '@core/models/schedule/ITimeSpan';

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

const createDate = (timeSpan: ITimeSpan) => new Date(new Date().setHours(timeSpan.hour, timeSpan.minute, 0, 0));

export const changeScheduleItemsDate = (items: IScheduleItem[]): IScheduleItemReceive[] =>
    items.map((el) => ({
        ...el,
        start: createDate(el.start),
        end: createDate(el.end),
    }));
