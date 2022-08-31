import { Component, ElementRef, HostListener, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { IMeetingBooking } from '@core/models/IMeetingBooking';
import { IMeetingMembersRequest } from '@core/models/IMeetingMemberRequest';
import { MeetingBookingsService } from '@core/services/meeting-bookings.service';
import { NotificationService } from '@core/services/notification.service';
import { TeamService } from '@core/services/team.service';
import { paddingLeftRigthOnBookingPage, widthOfItemInfoOnBookingPage, widthOfMemberItemContainerOnBookingPage }
    from '@shared/constants/booking-page-element-sizes';

@Component({
    selector: 'app-bookings-page',
    templateUrl: './bookings-page.component.html',
    styleUrls: ['./bookings-page.component.sass'],
})
export class BookingsPageComponent extends BaseComponent implements OnInit {
    public teamId?: number;

    public numberOfMembersToDisplay: number;

    public meetings: IMeetingBooking[];

    constructor(
        private el: ElementRef,
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
        //console.log(this.container.offsetWidth);
    }

    public ngOnInit(): void {
        // eslint-disable-next-line no-debugger
        debugger;

        this.detectMeetingMembersNumber();
        this.teamService.currentTeamEmitted$
            .subscribe(teamId => {
                this.teamId = teamId;
                const meetingMemberRequest: IMeetingMembersRequest = {
                    teamId: this.teamId,
                    numberOfMembersToDisplay: this.numberOfMembersToDisplay,
                };

                this.loadMeetings(meetingMemberRequest);
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

    detectMeetingMembersNumber() {
        // eslint-disable-next-line no-debugger
        debugger;

        const widthOfListOfMembers = this.getPageSize();

        this.numberOfMembersToDisplay = Math.round(widthOfListOfMembers / widthOfMemberItemContainerOnBookingPage);
        console.log(this.numberOfMembersToDisplay);
    }

    getPageSize(): number {
        const bookingContainer = (<HTMLElement> this.el.nativeElement)
            .querySelector('.bookings-container') as HTMLElement;

        const bookingContainerWidth = bookingContainer.offsetWidth;
        const widthOfBokingSlot = bookingContainerWidth - paddingLeftRigthOnBookingPage * 2;

        const widthOfListOfMembers = widthOfBokingSlot - widthOfItemInfoOnBookingPage;

        console.log(widthOfListOfMembers);

        return widthOfListOfMembers;
    }

    // goToPage(pageName: string) {
    //     this.router.navigate([`${pageName}`]);
    // }
    goToPage(pageName: string) {
        console.log(pageName);
    }
}
