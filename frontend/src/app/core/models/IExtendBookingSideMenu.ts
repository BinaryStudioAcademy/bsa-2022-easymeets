import { Time } from '@angular/common';

import { IUser } from './IUser';
import { LocationType } from './locationType';

export interface IExternalBookingSideMenu {
    user: IUser;

    duration?: number;

    location?: LocationType;

    timeStart?: Time;

    timeFinish?: Time;

    date?: Date;
}
