import { LocationType } from '@shared/enums/locationType';
import { TZone } from 'moment-timezone-picker';

import { IAvailabilitySlotMember } from './IAvailabilitySlotMember';
import { ITeam } from './ITeam';
import { IUser } from './IUser';

export interface IExternalBookingSideMenu {
    user: IUser;

    team: ITeam;

    teamSlotMembers?: IAvailabilitySlotMember[];

    duration?: number;

    location?: LocationType;

    timeFinish?: Date;

    date?: Date;

    slotId?: bigint;

    teamId?: bigint;

    timeZone?: TZone;
}
