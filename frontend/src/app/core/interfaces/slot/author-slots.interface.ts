import { IUser } from "@core/interfaces/user/user-interface";
import { ISlot } from "@core/interfaces/slot/slot-interface";

export interface IAuthorSlots {
    author: IUser;
    availabilitySlots: Array<ISlot>;
}
