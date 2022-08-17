import { INewAdvancedSettings } from '@core/models/new-availability-slot/INewAdvancedSettings';
import { INewEventDetails } from '@core/models/new-availability-slot/INewEventDetails';
import { INewGeneralSettings } from '@core/models/new-availability-slot/INewGeneralSettings';

export interface INewAvailability {
    teamId: number;
    hasAdvancedSettings: boolean;
    generalDetails: INewGeneralSettings;
    eventDetails: INewEventDetails;
    advancedSettings: INewAdvancedSettings | null;
}
