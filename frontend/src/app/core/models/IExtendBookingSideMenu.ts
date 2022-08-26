import { IAvailabilitySlotMember } from './IAvailabilitySlotMember';
import { ITeam } from './ITeam';
import { IUser } from './IUser';
import { LocationType } from './locationType';

export interface IExternalBookingSideMenu {
    user: IUser;

    team: ITeam;

    teamSlotMembers?: IAvailabilitySlotMember[];

    duration?: number;

    location?: LocationType;

    timeFinish?: Date;

    date?: Date;
}
