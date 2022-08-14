import { ISlot } from '@core/interfaces/slot/slot-interface';
import { ITeam } from '@core/interfaces/team-interface';

export interface ITeamSlots {
    team: ITeam;
    availabilitySlots: Array<ISlot>;
}
