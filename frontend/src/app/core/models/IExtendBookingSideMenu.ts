import { IUser } from './IUser';
import { LocationType } from './locationType';

export interface IExternalBookingSideMenu {
    user: IUser;

    duration?: number;

    location?: LocationType;

    timeFinish?: Date;

    date?: Date;
}
