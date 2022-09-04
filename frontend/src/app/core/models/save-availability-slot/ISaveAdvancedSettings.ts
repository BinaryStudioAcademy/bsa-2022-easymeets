import { ActivityType } from '@core/enums/activity-type.enum';

export interface ISaveAdvancedSettings {
    activityType: ActivityType;
    days: number;
    maxNumberOfBookings: number;
    paddingMeeting: number;
    minBookingMeetingDifference: number;
    frequency: number;
}
