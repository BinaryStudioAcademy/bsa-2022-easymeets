import { Time } from '@angular/common';

import { IUser } from './IUser';

export interface IExtendBookingSideMenu {
    user: IUser;
    duration: number;
    location: string;
    timeStart: Time;
    timeFinish: Time;
    date: Date;
}
