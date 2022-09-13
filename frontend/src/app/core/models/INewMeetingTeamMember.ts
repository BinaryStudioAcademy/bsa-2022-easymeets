import { IUnavailability } from '@core/models/IUnavailability';

export interface INewMeetingMember {
    id: bigint;
    name: string;
    image?: string;
    unavailabilityItems: IUnavailability[];
}
