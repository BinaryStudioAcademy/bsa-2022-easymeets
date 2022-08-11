import { AvailabilitySlot } from './availiability-slot';

export interface TeamWithSlots {
    name: string
    pageLink: string
    availabilitySlots: Array<AvailabilitySlot>
}
