import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { IMeetingBooking } from '@core/models/IMeetingBooking';
import { IMeetingMembersRequest } from '@core/models/IMeetingMemberRequest';
import { MeetingBookingsService } from '@core/services/meeting-bookings.service';
import { NotificationService } from '@core/services/notification.service';
import { TeamService } from '@core/services/team.service';

@Component({
    selector: 'app-bookings-page',
    templateUrl: './bookings-page.component.html',
    styleUrls: ['./bookings-page.component.sass'],
})
export class BookingsPageComponent extends BaseComponent implements OnInit {
    public listScrollBlock = document.getElementsByClassName('listScrollBlock') as HTMLCollectionOf<HTMLElement>;

    public booker = document.getElementsByClassName('boker') as HTMLCollectionOf<HTMLElement>;

    public meetingMemberRequest: IMeetingMembersRequest;

    public teamId?: number;

    public numberOfMembersToDisplay: number;

    constructor(
        private meetingService: MeetingBookingsService,
        private router: Router,
        private notifications: NotificationService,
        private teamService: TeamService,
    ) {
        super();
        this.meetings = [];
    }

    public meetings: IMeetingBooking[];

    public ngOnInit(): void {
        this.teamService.currentTeamEmitted$
            .subscribe(teamId => {
                this.teamId = teamId;
                this.meetingMemberRequest = { teamId: this.teamId, numberOfMembersToDisplay: 4 };

                this.loadMeetings(this.meetingMemberRequest);
            });
    }

    private loadMeetings(meetingMemberRequest: IMeetingMembersRequest) {
        // eslint-disable-next-line no-debugger
        debugger;
        this.meetingService
            .getThreeMeetings(meetingMemberRequest)
            .pipe(this.untilThis)
            .subscribe(
                (resp: IMeetingBooking[]) => {
                    this.meetings = resp;
                },
                error => this.notifications.showErrorMessage(error),
            );
    }

    detectMeetingMembersNumber() {
        // eslint-disable-next-line no-debugger
        debugger;
        console.log(this.listScrollBlock[0]);
        const first = this.listScrollBlock[0];
        const width = first.offsetWidth;
        const height = first.offsetHeight;

        console.log(width, height);
        const bookerWidth = this.booker[0].offsetWidth;
        const bookerHeight = this.booker[0].offsetHeight;

        console.log(bookerWidth, bookerHeight);
        this.numberOfMembersToDisplay = width / bookerWidth;
    }

    // goToPage(pageName: string) {
    //     this.router.navigate([`${pageName}`]);
    // }
    goToPage(pageName: string) {
        this.detectMeetingMembersNumber();
        console.log(pageName);
    }
}
