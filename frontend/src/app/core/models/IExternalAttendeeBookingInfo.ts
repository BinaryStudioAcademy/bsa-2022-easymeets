import { IExternalAvailabilitySlot } from './IExternalAvailabilitySlot';
import { IExternalUser } from './IExternalUser';

export interface IExternalAttendeeBookingInfo {
    user: IExternalUser;
    personalSlots: IExternalAvailabilitySlot[];
}
