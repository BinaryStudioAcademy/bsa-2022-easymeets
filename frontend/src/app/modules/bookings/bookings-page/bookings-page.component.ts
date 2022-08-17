import { Component, OnInit } from '@angular/core';
import { BaseComponent } from '@core/base/base.component';
import { IMeetingBooking } from '@core/models/IMeetingBooking';
import { MeetingBookingsService } from '@core/services/meeting-bookings.service';

@Component({
    selector: 'app-bookings-page',
    templateUrl: './bookings-page.component.html',
    styleUrls: ['./bookings-page.component.sass'],
})
export class BookingsPageComponent extends BaseComponent implements OnInit {
    constructor(public meetingService: MeetingBookingsService) {
        super();
        this.meetings = [];
    }

    public meetings: IMeetingBooking[];

    public ngOnInit(): void {
        this.meetingService
            .getMeetingsForBookings()
            .pipe(this.untilThis)
            .subscribe((resp: IMeetingBooking[]) => {
                this.meetings = resp;
            });
    }
}
