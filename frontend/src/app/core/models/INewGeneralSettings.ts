import { SlotType } from '@core/enums/slot-type.enum';

export interface INewGeneralSettings {
    meetingLocation: string;
    name: string;
    type: SlotType;
    size: number;
    frequency: number;
    isEnabled: boolean;
    isVisible: boolean;
}
