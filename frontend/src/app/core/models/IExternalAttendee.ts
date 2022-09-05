import { TZone } from 'moment-timezone-picker';

export interface IExternalAttendee {
    availabilitySlotId?: bigint;
    name: string;
    email: string;
    timeZone?: TZone;
}
