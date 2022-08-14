import { AvailabilitySlot } from './availiability-slot';

export interface AvailabilitySlotsGroupByTeamsDto {
    name: string,
    availabilitySlots: AvailabilitySlot[]
}
