import { Color } from '@core/enums/color.enum';
import { SlotType } from '@core/enums/slot-type.enum';
import { IAdvancedSlotSettings } from '@core/models/IAdvancedSlotSettings';
import { ISlotMember } from '@core/models/save-availability-slot/ISlotMember';
import { ISchedule } from '@core/models/schedule/ISchedule';
import { LocationType } from '@shared/enums/locationType';

import { ISaveConfirmationEmailDetails } from './save-availability-slot/ISaveConfirmationEmailDetails';
import { IAvailabilitySlotMember } from './IAvailabilitySlotMember';
import { IQuestion } from './IQuestion';

export interface IAvailabilitySlot {
    id: bigint;
    teamId?: bigint;
    name: string;
    authorName: string;
    type: SlotType,
    size: number;
    link: string;
    isEnabled: boolean;
    isVisible: boolean;
    locationType: LocationType;
    meetingRoom?: string;
    members: IAvailabilitySlotMember[];
    advancedSlotSettingsId?: number;
    advancedSlotSettings?: IAdvancedSlotSettings;
    questions: IQuestion[];
    schedule: ISchedule;
    slotMembers: ISlotMember[]
    welcomeMessage: string;
    color: Color;
    language: string;
    bookingsPerDay: number;
    passwordProtectionIsUsed: boolean;
    passwordProtection?: string;
    timeZoneVisibility: boolean;
    emailTemplateSettings?: ISaveConfirmationEmailDetails[];
}
