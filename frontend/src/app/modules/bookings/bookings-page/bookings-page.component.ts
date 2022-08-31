import { Component, HostListener, OnInit } from '@angular/core';
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

    public container = document.getElementsByClassName('bookings-container') as HTMLCollectionOf<HTMLElement>;

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

    @HostListener('window:resize', ['$event'])
    onResize() {
        console.log(this.container[0].offsetWidth);
    }

    public meetings: IMeetingBooking[];

    public ngOnInit(): void {
        // eslint-disable-next-line no-debugger
        debugger;
        const width = this.container[0].offsetWidth;

        this.detectMeetingMembersNumber(width);
        this.teamService.currentTeamEmitted$
            .subscribe(teamId => {
                this.teamId = teamId;
                this.meetingMemberRequest = { teamId: this.teamId, numberOfMembersToDisplay: this.numberOfMembersToDisplay };

                this.loadMeetings(this.meetingMemberRequest);
            });
    }

    private loadMeetings(meetingMemberRequest: IMeetingMembersRequest) {
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

    detectMeetingMembersNumber(widthOfContainer: number) {
        // eslint-disable-next-line no-debugger
        debugger;

        console.log(widthOfContainer);

        const widthOfInfoRow = widthOfContainer - 200;

        console.log(widthOfInfoRow);

        const widthOfItemInfo = 291;

        const widthOfListOfMembers = widthOfInfoRow - widthOfItemInfo;

        console.log(widthOfListOfMembers);
        const numberOfMembersToDisplay = widthOfListOfMembers / 236;

        this.numberOfMembersToDisplay = Math.round(numberOfMembersToDisplay);
        console.log(Math.round(numberOfMembersToDisplay));
    }

    // goToPage(pageName: string) {
    //     this.router.navigate([`${pageName}`]);
    // }
    goToPage(pageName: string) {
        console.log(pageName);
    }
}
