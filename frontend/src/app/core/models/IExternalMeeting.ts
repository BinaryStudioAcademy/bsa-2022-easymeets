import { ISlotMember } from '@core/models/save-availability-slot/ISlotMember';
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
    members?: ISlotMember[];
}
