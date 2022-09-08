import { ITimeZone } from '@core/models/ITimeZone';
import { ILocalUser } from '@core/models/IUser';

export const getDefaultTimeZone = (): ITimeZone => {
    const user = JSON.parse(localStorage.getItem('user')!) as ILocalUser;

    return user?.timeZone ?? { nameValue: '', timeValue: '' };
};
