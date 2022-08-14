import { IAuthorSlots } from '@core/interfaces/slot/author-slots.interface';
import { ITeamSlots } from '@core/interfaces/slot/team-slots-interface';

export interface ISlotsResponse {
    personalAvailabilitySlotsWithAuthors: Array<IAuthorSlots>;
    teamAvailabilitySlotsWithTeams: Array<ITeamSlots>;
}
