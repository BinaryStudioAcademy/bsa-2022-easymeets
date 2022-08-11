import { AvailabilitySlot } from './availiability-slot';

export interface TeamWithSlot {
    name: string
    pageLink: string
    availabilitySlots: Array<AvailabilitySlot>
}
