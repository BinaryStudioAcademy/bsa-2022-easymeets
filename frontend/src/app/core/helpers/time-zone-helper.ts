import { ITimeZone } from '@core/models/ITimeZone';
import { ILocalUser } from '@core/models/IUser';

export const getDefaultTimeZone = (): ITimeZone => {
    const user = JSON.parse(localStorage.getItem('user')!) as ILocalUser;

    return user?.timeZone ?? { nameValue: '', timeValue: '' };
};

export function convertLocalDateToUTCWithUserSelectedTimeZone(date: Date, timeZone: ITimeZone) {
    const dateWithoutLocalOffset = new Date(date.getTime() - 2 * (date.getTimezoneOffset() * 60000));

    return new Date(
        dateWithoutLocalOffset.toLocaleString('en-US', {
            timeZone: timeZone.nameValue,
        }),
    );
}
