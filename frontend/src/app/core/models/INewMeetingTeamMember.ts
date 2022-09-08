import { IUnavailability } from '@core/models/IUnavailability';

export interface INewMeetingMember {
    id: number;
    name: string;
    image?: string;
    unavailabilityItems: IUnavailability[];
}
