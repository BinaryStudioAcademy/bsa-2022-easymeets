import { IAvailabilitySlotMember } from './IAvailabilitySlotMember';
import { IAdvancedSlotSettings } from "@core/models/IAdvancedSlotSettings";

export interface IAvailabilitySlot {
    id: number;
    name: string;
    authorName: string;
    size: number;
    link: string;
    isEnabled: boolean;
    isVisible: boolean;
    locationName: string;
    members: IAvailabilitySlotMember[];
    advancedSlotSettingsId?: number;
    advancedSlotSettings?: IAdvancedSlotSettings;
    welcomeMessage: string;
    frequency: number;
    language: string;
    bookingsPerDay: number;
    allowToAddGuests: boolean;
    PasswordProtection?: string;
    TimeZoneVisibility: boolean;
}
