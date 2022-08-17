import { IAvailabilitySlotMember } from './IAvailabilitySlotMember';
import { LocationType } from './locationType';

export interface IAvailabilitySlot {
    id: bigint;
    name: string;
    authorName: string;
    size: number;
    link: string;
    isEnabled: boolean;
    isVisible: boolean;
    locationType: LocationType;
    members: IAvailabilitySlotMember[];
}
