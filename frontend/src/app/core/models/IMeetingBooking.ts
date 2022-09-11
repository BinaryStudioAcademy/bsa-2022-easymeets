import { IUserMeeting } from './IUserMeeting';

export interface IMeetingBooking {
    id: number;
    meetingTime: Date;
    meetingTitle: string;
    meetingDuration: number;
    meetingLink: string;
    membersTitle: string;
    location: string;
    meetingCount: number;
    meetingMembers: Array<IUserMeeting>;
}
