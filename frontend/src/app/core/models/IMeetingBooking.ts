import { LocationType } from '@shared/enums/locationType';

import { IUserMeeting } from './IUserMeeting';

export interface IMeetingBooking {
    id: number;
    meetingTime: Date;
    meetingTitle: string;
    meetingDuration: number;
    meetingLink: string;
    membersTitle: string;
    locationType: LocationType;
    meetingRoom?: string;
    meetingCount: number;
    meetingMembers: Array<IUserMeeting>;
}
