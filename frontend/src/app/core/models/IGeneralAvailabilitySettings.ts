import { ActivityType } from '@core/enums/activity-type.enum';
import { Color } from '@core/enums/color.enum';

export interface IGeneralAvailabilitySettings {
    slotSize: number;

    slotFrequency: number;

    meetingLocation: string;

    meetingPadding: number;

    slotActivityOption: ActivityType;

    slotActivityValue: number;

    meetingName: string;

    maxBookings: number;

    minBookingMeetingDifference: number;

    hideFromCommon: boolean;

    color: Color;
}
