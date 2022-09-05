import { LocationType } from '@shared/enums/locationType';

export interface IExternalMeeting {
    teamId?: bigint;
    createdBy?: bigint;
    availabilitySlotId?: bigint;
    name: string;
    locationType?: LocationType;
    duration?: number;
    startTime?: Date;
    meetingLink: string;
}
