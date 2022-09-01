import { Component, Input } from '@angular/core';
import { getMembersForBookedWindow } from '@core/helpers/booked-window-members-helper';
import { LocationTypeMapping } from '@core/helpers/location-type-mapping';
import { INewMeetingMember } from '@core/models/INewMeetingTeamMember';
import { LocationType } from '@shared/enums/locationType';

/*export interface IBookingWindowInfo {
    date?: string;
    time?: Date;
    duration?: number;
    meetingName?: string;
    participants?: INewMeetingMember[];
    location?: LocationType;
    link?: string;
}*/

@Component({
    selector: 'app-booking-window',
    templateUrl: './booking-window.component.html',
    styleUrls: ['./booking-window.component.sass'],
})
export class BookingWindowComponent {
    @Input() maxVisibleMembers: number = 10;

    /*@Input() bookedInfo: IBookingWindowInfo;*/

    locationTypeMapping = LocationTypeMapping;

    @Input() date: string;

    @Input() time: Date = new Date();

    @Input() duration: number = 30;

    @Input() meetingName: string = '30 Min Meeting';

    @Input() participants: INewMeetingMember[] = getMembersForBookedWindow();

    @Input() location: LocationType = LocationType.GoogleMeet;

    @Input() link: string = '.../asdasdas/sds/30 Min Meeting';
}
