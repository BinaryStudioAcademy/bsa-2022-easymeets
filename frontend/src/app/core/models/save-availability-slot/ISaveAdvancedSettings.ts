import { ActivityType } from '@core/enums/activity-type.enum';
import { Color } from '@core/enums/color.enum';

export interface ISaveAdvancedSettings {
    activityType: ActivityType;
    days: number;
    maxNumberOfBookings: number;
    paddingMeeting: number;
    minBookingMeetingDifference: number;
    color: Color;
}
