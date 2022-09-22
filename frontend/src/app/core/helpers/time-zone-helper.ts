import { ITimeZone } from '@core/models/ITimeZone';

export const millisInHour = 3600 * 1000;
export const millisInMinute = 60 * 1000;

export const setTimeZone = (timeZone: ITimeZone) => {
    localStorage.setItem('timeZone', JSON.stringify({ nameValue: timeZone.nameValue, timeValue: timeZone.timeValue }));
};

export const getDeviceTimeZone = () => {
    const matches = new Date().toString().match(new RegExp('(?<=GMT)[\\+-]\\d{4}'));

    if (matches === null) {
        throw new Error('Cannot pick up current time zone');
    }

    const hours = matches[0].substring(0, 3);
    const minutes = matches[0].substring(3);

    const timeZoneValue = `${hours}:${minutes}`;
    const timeZoneName = Intl.DateTimeFormat().resolvedOptions().timeZone;

    const deviceTimeZone = { nameValue: timeZoneName, timeValue: timeZoneValue } as ITimeZone;

    return deviceTimeZone;
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

export const applyTimeZoneOffsetToDate = (date: Date, minutesOffset: number, negateOffset: boolean = false) => {
    const sign = negateOffset ? -1 : 1;

    return new Date(date.getTime() - sign * minutesOffset * millisInMinute);
};

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
