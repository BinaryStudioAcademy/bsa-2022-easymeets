import { IEventDetailSettings } from '@core/models/IEventDetailSettings';
import { IGeneralAvailabilitySettings } from '@core/models/IGeneralAvailabilitySettings';
import { ISchedule } from '@core/models/schedule/ISchedule';

export interface IUpdateAvailability {
    generalDetailsUpdate: IGeneralAvailabilitySettings,
    eventDetailsUpdate: IEventDetailSettings,
    schedule: ISchedule,
    hasAdvancedSettings: boolean,
    isActive: boolean
}
