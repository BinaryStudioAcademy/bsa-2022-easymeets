import { LocationType } from '@shared/enums/locationType';

import { INewMeetingMember } from './INewMeetingTeamMember';

export interface IUpdateMeeting {
    id: bigint;
    name: string;
    teamId?: number;
    locationType: LocationType;
    meetingRoom?: string;
    duration: number;
    startTime: string;
    meetingLink: string;
    meetingMembers: INewMeetingMember[];
}
