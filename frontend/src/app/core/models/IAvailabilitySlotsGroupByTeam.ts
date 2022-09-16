import { IAvailabilitySlot } from './IAvailabilitySlot';

export interface IAvailabilitySlotsGroupByTeamsDto {
    id: bigint;
    name: string;
    image: string;
    availabilitySlots: IAvailabilitySlot[];
}
