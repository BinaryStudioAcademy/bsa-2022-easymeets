import { IAvailabilitySlot } from './IAvailabilitySlot';

export interface IAvailabilitySlotsGroupByTeamsDto {
    name: string;
    availabilitySlots: IAvailabilitySlot[];
}
