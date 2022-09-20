import { ITimeZone } from '@core/models/ITimeZone';
import { ILocalUser } from '@core/models/IUser';

export const millisInHour = 3600 * 1000;
export const millisInMinute = 60 * 1000;

export const getDefaultTimeZone = (): ITimeZone => {
    const user = JSON.parse(localStorage.getItem('user')!) as ILocalUser;

    return user?.timeZone ?? { nameValue: '', timeValue: '' };
};

/**
 * Returns number of milliseconds in time zone
 *
 * @example
 * +01:00 -> 3600000
 * -02:30 -> -9000000
 */
export const parseTimeZoneIntoMilliseconds = (timeZone: string): number => {
    const match = timeZone.match(new RegExp('(?<sign>[\\+-])(?<hours>\\d{2}):(?<minutes>\\d{2})'));
    const signStr = match?.groups?.['sign'];
    const hoursStr = match?.groups?.['hours'];
    const minutesStr = match?.groups?.['minutes'];

    if (!signStr || !hoursStr || !minutesStr) {
        return 0;
    }

    const base = 10;
    const sign = signStr === '+' ? 1 : -1;
    const hours = parseInt(hoursStr, base);
    const minutes = parseInt(minutesStr, base);

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
    // Date object always contains local device time zone, which is applied to date itself automatically, when it is formatted in any way.
    //      (Sat Sep 24 2022 18:00:00 GMT+0300).toUTCString() --->
    //      Sat, 24 Sep 2022 15:00:00 GMT
    //
    // So we need to negate this device time zone before formatting, in order to get only custom time zone applied.
    const deviceTimeZoneNegated = applyTimeZoneOffsetToDate(date, date.getTimezoneOffset());
    const customTimeZoneApplied = applyTimeZoneOffsetToDate(
        deviceTimeZoneNegated,
        parseTimeZoneIntoMilliseconds(customTimeZone.timeValue) / millisInMinute,
    );

    return customTimeZoneApplied.toUTCString();
};
