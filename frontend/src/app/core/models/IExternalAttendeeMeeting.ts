import { IExternalAttendee } from './IExternalAttendee';
import { IExternalMeeting } from './IExternalMeeting';

export interface IExternalAttendeeMeeting {
    attendee: IExternalAttendee;
    meeting: IExternalMeeting;
}
