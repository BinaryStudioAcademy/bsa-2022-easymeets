import { Color } from '@core/enums/color.enum';
import { SlotType } from '@core/enums/slot-type.enum';
import { LocationType } from '@shared/enums/locationType';

export interface ISaveGeneralSettings {
    locationType: LocationType;
    name: string;
    type: SlotType;
    size: number;
    isEnabled: boolean;
    isVisible: boolean;
    color: Color;
}
