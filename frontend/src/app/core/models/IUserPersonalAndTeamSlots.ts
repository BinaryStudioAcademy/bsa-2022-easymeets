import { IAvailabilitySlotsGroupByTeamsDto } from './IAvailabilitySlotsGroupByTeam';
import { IAvailabilitySlot } from './IAvailiabilitySlot';

export interface IUserPersonalAndTeamSlots {
    userSlots: IAvailabilitySlot[],
    teamSlots: IAvailabilitySlotsGroupByTeamsDto[]
}
