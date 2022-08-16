import { IAvailabilitySlotMember } from './IAvailabilitySlotMember';

export interface IAvailabilitySlot {
    id: bigint;
    name: string;
    authorName: string;
    size: number;
    link: string;
    isEnabled: boolean;
    isVisible: boolean;
    locationName: string;
    members: IAvailabilitySlotMember[];
}
