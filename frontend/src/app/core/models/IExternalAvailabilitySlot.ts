import { LocationType } from '@shared/enums/locationType';

export interface IExternalAvailabilitySlot {
    id: bigint;
    teamId: bigint;
    name: string;
    size: number;
    locationType: LocationType;
    meetingRoom?: string;
    link: string;
}
