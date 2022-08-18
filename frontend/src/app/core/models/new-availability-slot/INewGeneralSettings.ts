import { SlotType } from '@core/enums/slot-type.enum';
import { LocationType } from '@core/models/locationType';

export interface INewGeneralSettings {
    locationType: LocationType;
    name: string;
    type: SlotType;
    size: number;
    frequency: number;
    isEnabled: boolean;
    isVisible: boolean;
}
