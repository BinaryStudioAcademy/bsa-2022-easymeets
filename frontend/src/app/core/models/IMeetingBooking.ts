import { IUserMeeting } from './IUserMeeting';

export interface IMeetingBooking {
    meetingTime: string;
    meetingTitle: string;
    meetingDuration: string;
    membersTitle: string;
    meetingCount: number;
    meetingMembers: Array<IUserMeeting>;
}
