import { IGeneralAvailabilitySettings } from "@core/models/IGeneralAvailabilitySettings";
import { IEventDetailSettings } from "@core/models/IEventDetailSettings";

export interface IUpdateAvailability {
    generalDetailsUpdate: IGeneralAvailabilitySettings,
    eventDetailsUpdate: IEventDetailSettings,
    hasAdvancedSettings: boolean,
    isActive: boolean
}
