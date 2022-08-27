import { ISaveAdvancedSettings } from '@core/models/save-availability-slot/ISaveAdvancedSettings';
import { ISaveEventDetails } from '@core/models/save-availability-slot/ISaveEventDetails';
import { ISaveGeneralSettings } from '@core/models/save-availability-slot/ISaveGeneralSettings';
import { ISchedule } from '@core/models/schedule/ISchedule';

import { ISaveConfirmationEmailDetails } from './ISaveConfirmationEmailDetails';

export interface ISaveAvailability {
    teamId?: number;
    hasAdvancedSettings: boolean;
    generalDetails: ISaveGeneralSettings;
    eventDetails: ISaveEventDetails;
    advancedSettings: ISaveAdvancedSettings | null;
    schedule: ISchedule;
    emailSettings: ISaveConfirmationEmailDetails;
}
