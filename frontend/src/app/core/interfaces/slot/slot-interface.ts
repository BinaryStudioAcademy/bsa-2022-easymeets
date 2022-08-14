import { SlotType } from "@core/enums/slot-type.enum";
import { ILocation } from "@core/interfaces/location.interface";
import { IUser } from "@core/interfaces/user/user-interface";

export interface ISlot {
    id: number;
    teamId: number;
    locationId: number;
    location?: ILocation;
    advancedSlotSettingsId: number;
    name: string;
    description: string;
    link: string;
    type: SlotType;
    size: number;
    frequency: number;
    isEnabled: boolean;
    isVisible: boolean;
    members?: IUser[];
}
