import { INewMeetingMember } from './INewMeetingTeamMember';
import { LocationType } from './locationType';

export interface INewMeeting {
    name: string,
    location: LocationType,
    duration: number,
    startTime?: Date
    teamId?: number
    meetingMembers: INewMeetingMember[]
}
