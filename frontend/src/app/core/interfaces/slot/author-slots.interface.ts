import { ISlot } from '@core/interfaces/slot/slot-interface';
import { IUser } from '@core/interfaces/user/user-interface';

export interface IAuthorSlots {
    author: IUser;
    availabilitySlots: Array<ISlot>;
}
