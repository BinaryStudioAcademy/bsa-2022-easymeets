import { LocationType } from '@shared/enums/locationType';
import { TZone } from 'moment-timezone-picker';

import { IAvailabilitySlotMember } from './IAvailabilitySlotMember';
import { IExternalUser } from './IExternalUser';
import { ITeam } from './ITeam';

export interface IExternalBookingSideMenu {
    user: IExternalUser;

    team: ITeam;

    slotName?: string;

    teamSlotMembers?: IAvailabilitySlotMember[];

    duration?: number;

    location?: LocationType;

    meetingRoom?: string;

    timeFinish?: Date;

    date?: Date;

    slotId?: bigint;

    teamId?: bigint;

    timeZone?: TZone;
}
