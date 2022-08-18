import { IEventDetailSettings } from '@core/models/IEventDetailSettings';
import { IGeneralAvailabilitySettings } from '@core/models/IGeneralAvailabilitySettings';

export interface IUpdateAvailability {
    generalDetailsUpdate: IGeneralAvailabilitySettings,
    eventDetailsUpdate: IEventDetailSettings,
    hasAdvancedSettings: boolean,
    isActive: boolean
}
