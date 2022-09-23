import { formatDate } from '@angular/common';
import { ITimeZone } from '@core/models/ITimeZone';
import { ILocalUser } from '@core/models/IUser';

export const getDefaultTimeZone = (): ITimeZone => {
    const user = JSON.parse(localStorage.getItem('user')!) as ILocalUser;

    return user?.timeZone ?? { nameValue: '', timeValue: '' };
};

export const getDateStringWithoutLocalOffset = (date: Date, offsetHours?: number) =>
    new Date(date.getTime() - date.getTimezoneOffset() * 60000 - (offsetHours ?? 0) * 60 * 60000).toJSON();

export function convertLocalDateToUTCWithUserSelectedTimeZone(date: Date, timeZone: ITimeZone) {
    const dateWithoutLocalOffset = getDateStringWithoutLocalOffset(date);

    return formatDate(dateWithoutLocalOffset, 'yyyy-MM-ddTHH:mm:ss.SSSZZZ', 'en-US', timeZone.nameValue);
}
