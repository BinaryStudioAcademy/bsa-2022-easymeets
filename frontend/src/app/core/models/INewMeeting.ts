import { INewMeetingTeamMember } from './INewMeetingTeamMember';
import { LocationType } from './locationType';

export interface INewMeeting {
    name?: string,
    location?: LocationType,
    duration?: number,
    unitOfTime?: string
    startTime?: Date
    description?: string
    teamId?: number
    teamMembers: INewMeetingTeamMember[]
}
