import { ITeam } from "@core/interfaces/team-interface";
import { ISlot } from "@core/interfaces/slot/slot-interface";

export interface ITeamSlots {
    team: ITeam;
    availabilitySlots: Array<ISlot>;
}
