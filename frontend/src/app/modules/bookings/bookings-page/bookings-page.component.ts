import { Component, ElementRef, HostListener, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { IMeetingBooking } from '@core/models/IMeetingBooking';
import { IMeetingMembersRequest } from '@core/models/IMeetingMemberRequest';
import { MeetingBookingsService } from '@core/services/meeting-bookings.service';
import { NotificationService } from '@core/services/notification.service';
import { TeamService } from '@core/services/team.service';
import { desktopMaxWidth, desktopMinWidth, tabletMinWidth } from '@shared/constants/screen-variables';

@Component({
    selector: 'app-bookings-page',
    templateUrl: './bookings-page.component.html',
    styleUrls: ['./bookings-page.component.sass'],
})
export class BookingsPageComponent extends BaseComponent implements OnInit {
    public teamId?: number;

    public numberOfMembersToDisplay: number;

    public displayButton: boolean = false;

    public containerWidth: number;

    public meetings: IMeetingBooking[];

    public cachedMeetings: IMeetingBooking[];

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

    public ngOnInit(): void {
        this.getNumberOfItemsToDisplay();

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

    @HostListener('window:resize', ['$event'])
    onResize(event: any) {
        this.containerWidth = event.target.innerWidth;
        if (this.containerWidth < 1300) {
            this.numberOfMembersToDisplay = 3;
        }
        if (this.containerWidth < 1130) {
            this.numberOfMembersToDisplay = 2;
        }
        if (this.containerWidth < 885) {
            this.numberOfMembersToDisplay = 1;
        }
    }

    private loadMeetings(meetingMemberRequest: IMeetingMembersRequest) {
        this.meetingService
            .getThreeMeetings(meetingMemberRequest)
            .pipe(this.untilThis)
            .subscribe(
                (resp: IMeetingBooking[]) => {
                    this.sliceListAccordingToContainerSize(resp);
                    this.meetings = resp;
                },
                (error) => this.notifications.showErrorMessage(error),
            );
    }

    sliceListAccordingToContainerSize(responseMeeting: IMeetingBooking[]) {
        responseMeeting.forEach(meeting => {
            if (meeting.meetingCount >= this.numberOfMembersToDisplay) {
                if ((this.containerWidth > 1100 && this.containerWidth < 1336)) {
                    meeting.meetingMembers = meeting.meetingMembers.slice(0, this.numberOfMembersToDisplay - 1);
                }
                this.meetings.push(meeting);
            }
        });
    }

    getPageSize() {
        const bookingContainer = (<HTMLElement> this.el.nativeElement)
            .querySelector('.container') as HTMLElement;

        this.containerWidth = bookingContainer.offsetWidth;
    }

    getNumberOfItemsToDisplay() {
        this.getPageSize();

        if (this.containerWidth > desktopMaxWidth) {
            this.numberOfMembersToDisplay = 4;
        } else if (this.containerWidth > desktopMinWidth) {
            this.numberOfMembersToDisplay = 4;
        } else if (this.containerWidth < desktopMinWidth && this.containerWidth > tabletMinWidth) {
            this.numberOfMembersToDisplay = 2;
        } else if (this.containerWidth < tabletMinWidth || (this.containerWidth > tabletMinWidth && this.containerWidth < 1000)) {
            this.numberOfMembersToDisplay = 1;
        }
    }

    goToPage(pageName: string) {
        this.router.navigate([`${pageName}`]);
    }

    followMeetingLink(link: string) {
        window.open(link);
    }
}
