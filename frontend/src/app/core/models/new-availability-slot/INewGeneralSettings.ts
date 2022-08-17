import { LocationType } from '@core/enums/location-type.enum';
import { SlotType } from '@core/enums/slot-type.enum';

export interface INewGeneralSettings {
    locationType: LocationType;
    name: string;
    type: SlotType;
    size: number;
    frequency: number;
    isEnabled: boolean;
    isVisible: boolean;
}
