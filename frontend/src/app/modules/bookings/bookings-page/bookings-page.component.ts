import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { IMeetingBooking } from '@core/models/IMeetingBooking';
import { MeetingBookingsService } from '@core/services/meeting-bookings.service';

@Component({
    selector: 'app-bookings-page',
    templateUrl: './bookings-page.component.html',
    styleUrls: ['./bookings-page.component.sass'],
})
export class BookingsPageComponent extends BaseComponent implements OnInit {
    constructor(
        private meetingService: MeetingBookingsService,
        private router: Router,
    ) {
        super();
        this.meetings = [];
    }

    public meetings: IMeetingBooking[];

    public ngOnInit(): void {
        this.meetingService
            .getThreeMeetings()
            .pipe(this.untilThis)
            .subscribe((resp: IMeetingBooking[]) => {
                this.meetings = resp;
            });
    }

    public goToPage(pageName: string) {
        this.router.navigate([`${pageName}`]);
    }
}
