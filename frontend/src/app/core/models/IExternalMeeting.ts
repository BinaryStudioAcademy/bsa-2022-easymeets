import { LocationType } from '@shared/enums/locationType';

export interface IExternalMeeting {
    teamId?: bigint;
    createdBy?: bigint;
    availabilitySlotId?: bigint;
    name: string;
    locationType?: LocationType;
    meetingRoom?: string;
    duration?: number;
    startTime?: Date;
    meetingLink: string;
    createdAt: Date;
    updatedAt: Date;
}
