import { ISaveAdvancedSettings } from '@core/models/save-availability-slot/ISaveAdvancedSettings';
import { ISaveEventDetails } from '@core/models/save-availability-slot/ISaveEventDetails';
import { ISaveGeneralSettings } from '@core/models/save-availability-slot/ISaveGeneralSettings';
import { ISlotMember } from '@core/models/save-availability-slot/ISlotMember';
import { ISchedule } from '@core/models/schedule/ISchedule';
import { SlotParticipationOption } from '@shared/enums/slotParticipationOption';

import { IQuestion } from '../IQuestion';

import { ISaveConfirmationEmailDetails } from './ISaveConfirmationEmailDetails';

export interface ISaveAvailability {
    teamId?: number;
    hasAdvancedSettings: boolean;
    generalDetails: ISaveGeneralSettings;
    advancedSettings: ISaveAdvancedSettings | null;
    eventDetails: ISaveEventDetails;
    questions: IQuestion[];
    schedule?: ISchedule;
    slotMembers: ISlotMember[];
    templateSettings: ISaveConfirmationEmailDetails[];
    participationRule: SlotParticipationOption;
}
