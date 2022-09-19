import { ISaveAdvancedSettings } from '@core/models/save-availability-slot/ISaveAdvancedSettings';
import { ISaveEventDetails } from '@core/models/save-availability-slot/ISaveEventDetails';
import { ISaveGeneralSettings } from '@core/models/save-availability-slot/ISaveGeneralSettings';
import { ISlotMember } from '@core/models/save-availability-slot/ISlotMember';

import { IQuestion } from '../IQuestion';

import { ISaveConfirmationEmailDetails } from './ISaveConfirmationEmailDetails';

export interface ISaveAvailability {
    teamId?: number;
    hasAdvancedSettings: boolean;
    generalDetails: ISaveGeneralSettings;
    advancedSettings: ISaveAdvancedSettings | null;
    eventDetails: ISaveEventDetails;
    questions: IQuestion[];
    slotMembers: ISlotMember[]
    templateSettings: ISaveConfirmationEmailDetails[];
}
