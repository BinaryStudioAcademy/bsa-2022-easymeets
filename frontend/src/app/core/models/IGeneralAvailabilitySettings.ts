import { ActivityType } from '@core/enums/activity-type.enum';
import { Color } from '@core/enums/color.enum';

import { LocationType } from './locationType';

export interface IGeneralAvailabilitySettings {
    slotSize: number;

    slotFrequency: number;

    meetingLocation: LocationType;

    meetingPadding: number;

    slotActivityOption: ActivityType;

    slotActivityValue: number;

    meetingName: string;

    maxBookings: number;

    minBookingMeetingDifference: number;

    hideFromCommon: boolean;

    color: Color;
}
