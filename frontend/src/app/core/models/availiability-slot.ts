import { availabilitySlotMember } from './availability-slot-member';

export interface AvailabilitySlot {
    name: string;
    authorName: string;
    size: number;
    link: string;
    isEnabled: boolean
    isVisible: boolean
    locationName: string
    members: availabilitySlotMember[]
}
