import { ITimeZone } from './ITimeZone';

export interface IUserMeeting {
    name: string;
    email: string;
    image?: string;
    timeZone?: ITimeZone;
    booked: string;
}
