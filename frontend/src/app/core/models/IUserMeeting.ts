import { ITimeZone } from './ITimeZone';

export interface IUserMeeting {
    name: string;
    email: string;
    timeZone: ITimeZone;
    booked: string;
}
