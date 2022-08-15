import { ActivityType } from '@core/enums/activity-type.enum';

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
}
