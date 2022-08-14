import { AvailabilitySlotsGroupByTeamsDto } from './availability-slots-group-by-team';
import { AvailabilitySlot } from './availiability-slot';

export interface UserPersonalAndTeamSlots {
    userSlots: AvailabilitySlot[],
    teamSlots: AvailabilitySlotsGroupByTeamsDto[]
}
