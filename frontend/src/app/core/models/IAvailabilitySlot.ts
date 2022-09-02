import { Color } from '@core/enums/color.enum';
import { IAdvancedSlotSettings } from '@core/models/IAdvancedSlotSettings';
import { ISchedule } from '@core/models/schedule/ISchedule';
import { LocationType } from '@shared/enums/locationType';

import { ISaveConfirmationEmailDetails } from './save-availability-slot/ISaveConfirmationEmailDetails';
import { IAvailabilitySlotMember } from './IAvailabilitySlotMember';
import { IQuestion } from './IQuestion';

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
    questions: IQuestion[],
    schedule: ISchedule;
    welcomeMessage: string;
    color: Color;
    language: string;
    bookingsPerDay: number;
    passwordProtectionIsUsed: boolean;
    passwordProtection?: string;
    timeZoneVisibility: boolean;
    emailTemplateSettings?: ISaveConfirmationEmailDetails[];
}
