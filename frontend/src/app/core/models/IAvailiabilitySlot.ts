import { IAdvancedSlotSettings } from '@core/models/IAdvancedSlotSettings';

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
    advancedSlotSettingsId?: number;
    advancedSlotSettings?: IAdvancedSlotSettings;
    welcomeMessage: string;
    frequency: number;
    language: string;
    bookingsPerDay: number;
    allowToAddGuests: boolean;
    passwordProtectionIsUsed: boolean;
    passwordProtection?: string;
    TimeZoneVisibility: boolean;
}
