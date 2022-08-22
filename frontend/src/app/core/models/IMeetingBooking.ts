import { IUserMeeting } from './IUserMeeting';

export interface IMeetingBooking {
    meetingTime: string;
    meetingTitle: string;
    meetingDuration: string;
    meetingLink: string;
    membersTitle: string;
    location: string;
    meetingCount: number;
    meetingMembers: Array<IUserMeeting>;
}
