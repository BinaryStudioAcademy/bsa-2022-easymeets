import { IAvailabilitySlot } from './IAvailabilitySlot';
import { IAvailabilitySlotsGroupByTeamsDto } from './IAvailabilitySlotsGroupByTeam';

export interface IUserPersonalAndTeamSlots {
    userSlots: IAvailabilitySlot[];
    teamSlots: IAvailabilitySlotsGroupByTeamsDto[];
}
