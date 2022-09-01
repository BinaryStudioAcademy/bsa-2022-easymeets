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

    @Input() date: string = '22 Aug 2022';

    time: Date = new Date();

    duration: number = 30;

    meetingName: string = '30 Min Meeting';

    participants: INewMeetingMember[] = getMembersForBookedWindow();

    location: LocationType = LocationType.GoogleMeet;

    link: string = '.../asdasdas/sds/30 Min Meeting';

    /*constructor(@Inject(MAT_DIALOG_DATA) public data: IBookingWindowInfo) {
        this.bookedInfo.date = data.date;
        this.bookedInfo.time = data.time;
        this.bookedInfo.duration = data.duration;
        this.bookedInfo.meetingName = data.meetingName;
        this.bookedInfo.participants = data.participants;
        this.bookedInfo.location = data.location;
        this.bookedInfo.link = data.link;
    }*/
}
