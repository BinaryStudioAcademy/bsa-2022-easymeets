import { LocationType } from '@shared/enums/locationType';

import { INewMeetingMember } from './INewMeetingTeamMember';

export interface IMeeting {
    id: bigint;
    meetingTime: Date;
    meetingTitle: string;
    meetingDuration: number;
    meetingLink: string;
    membersTitle: string;
    locationType: LocationType;
    meetingRoom?: string;
    meetingCount: number;
    meetingMembers: INewMeetingMember[];
}
