import { SlotType } from '@core/enums/slot-type.enum';
import { LocationType } from '@shared/enums/locationType';

export interface ISaveGeneralSettings {
    locationType: LocationType;
    name: string;
    type: SlotType;
    size: number;
    frequency: number;
    isEnabled: boolean;
    isVisible: boolean;
}
