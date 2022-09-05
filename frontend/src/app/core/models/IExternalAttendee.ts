import { TimeZone } from '@shared/enums/timeZone';

export interface IExternalAttendee {
    availabilitySlotId?: bigint;
    name: string;
    email: string;
    timeZone?: TimeZone;
}
