import { ITimeZone } from '@core/models/ITimeZone';

export const millisInHour = 3600 * 1000;
export const millisInMinute = 60 * 1000;

export const setTimeZone = (timeZone: ITimeZone) => {
    localStorage.setItem('timeZone', JSON.stringify({ nameValue: timeZone.nameValue, timeValue: timeZone.timeValue }));
};

export const getDeviceTimeZone = () => {
    const offset = new Date().getTimezoneOffset();
    const hours = Math.abs(Math.trunc(offset / 60));
    const minutes = Math.abs(offset % 60);

    const hoursStr = hours < 10 ? `0${hours}` : `${hours}`;
    const minutesStr = minutes < 10 ? `0${minutes}` : `${minutes}`;

    const timeZoneValue = `${hoursStr}:${minutesStr}`;
    const timeZoneName = Intl.DateTimeFormat().resolvedOptions().timeZone;

    return { nameValue: timeZoneName, timeValue: timeZoneValue } as ITimeZone;
};

export const getDefaultTimeZone = (): ITimeZone => {
    const timeZone = JSON.parse(localStorage.getItem('timeZone')!) as ITimeZone;

    if (!timeZone) {
        const deviceTimeZone = getDeviceTimeZone();

        setTimeZone(deviceTimeZone);

        return deviceTimeZone;
    }

    return timeZone;
};

/**
 * @example
 * '+01:00' -> 3600000
 * '-02:30' -> -9000000
 */
export const parseTimeZoneIntoMilliseconds = (timeZone: string): number => {
    const sign = timeZone.substring(0, 1) === '+' ? 1 : -1;
    const hours = parseInt(timeZone.substring(1, 3), 10);
    const minutes = parseInt(timeZone.substring(4, 6), 10);

    return sign * (millisInHour * hours + millisInMinute * minutes);
};

export const applyTimeZoneToDate = (date: Date, timeZone: ITimeZone, negateTimeZone: boolean = false) => {
    const sign = negateTimeZone ? -1 : 1;

    return new Date(date.getTime() - sign * parseTimeZoneIntoMilliseconds(timeZone.timeValue));
};

export const applyTimeZoneOffsetToDate = (date: Date, minutesOffset: number) =>
    new Date(date.getTime() - minutesOffset * millisInMinute);

export const convertDateToUTCUsingCustomTimeZone = (date: Date, customTimeZone: ITimeZone) => {
    const deviceTimeZoneNegated = applyTimeZoneOffsetToDate(date, date.getTimezoneOffset());
    const customTimeZoneApplied = applyTimeZoneOffsetToDate(
        deviceTimeZoneNegated,
        parseTimeZoneIntoMilliseconds(customTimeZone.timeValue) / millisInMinute,
    );

    return customTimeZoneApplied.toUTCString();
};

export const getCurrentDate = () => {
    const currentUTC = applyTimeZoneToDate(new Date(), getDeviceTimeZone());
    const currentDate = applyTimeZoneToDate(currentUTC, getDefaultTimeZone(), true);

    return currentDate;
};
