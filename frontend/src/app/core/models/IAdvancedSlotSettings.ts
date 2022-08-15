import { Color } from "@core/enums/color.enum";
import { ActivityType } from "@core/enums/activity-type.enum";

export interface IAdvancedSlotSettings {
    activityType: ActivityType;
    days: number;
    startDate: Date;
    maxNumberOfBookings: number;
    paddingMeeting: number;
    minBookingMeetingDifference: number;
    color: Color;
}
