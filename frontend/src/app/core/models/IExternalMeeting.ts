import { ISlotMember } from '@core/models/save-availability-slot/ISlotMember';
import { LocationType } from '@shared/enums/locationType';

import { IQuestion } from './IQuestion';

export interface IExternalMeeting {
    teamId?: bigint;
    createdBy?: bigint;
    availabilitySlotId?: bigint;
    answers: IQuestion[];
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
