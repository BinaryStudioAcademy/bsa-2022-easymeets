import { LocationType } from '@shared/enums/locationType';

import { INewMeetingMember } from './INewMeetingTeamMember';

export interface INewMeeting {
    name: string,
    location: LocationType,
    duration: number,
    startTime: Date,
    meetingLink: string,
    createdAt: Date,
    meetingMembers: INewMeetingMember[]
}
