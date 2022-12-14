import { Color } from '@core/enums/color.enum';
import { LocationType } from '@shared/enums/locationType';

export interface IExternalAvailabilitySlot {
    id: bigint;
    teamId: bigint;
    name: string;
    size: number;
    locationType: LocationType;
    meetingRoom?: string;
    link: string;
    color: Color;
}
