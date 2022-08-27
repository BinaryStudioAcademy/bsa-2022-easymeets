import { IAdvancedSlotSettings } from '@core/models/IAdvancedSlotSettings';
import { ISchedule } from '@core/models/schedule/ISchedule';

import { ISaveConfirmationEmailDetails } from './save-availability-slot/ISaveConfirmationEmailDetails';
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
    advancedSlotSettingsId?: number;
    advancedSlotSettings?: IAdvancedSlotSettings;
    schedule: ISchedule;
    welcomeMessage: string;
    frequency: number;
    language: string;
    bookingsPerDay: number;
    allowToAddGuests: boolean;
    passwordProtectionIsUsed: boolean;
    passwordProtection?: string;
    timeZoneVisibility: boolean;
    confirmationEmailSettings?: ISaveConfirmationEmailDetails[];
}
