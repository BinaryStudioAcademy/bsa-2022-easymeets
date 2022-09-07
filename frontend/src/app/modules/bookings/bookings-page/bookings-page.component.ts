import { Component, ElementRef, HostListener, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { IMeetingBooking } from '@core/models/IMeetingBooking';
import { IMeetingMembersRequest } from '@core/models/IMeetingMemberRequest';
import { MeetingBookingsService } from '@core/services/meeting-bookings.service';
import { NotificationService } from '@core/services/notification.service';
import { TeamService } from '@core/services/team.service';
import { desktopMaxWidth, desktopWidthToContainFourItems, desktopWidthToContainThreeItems, desktopWidthToContainTwoItems,
    phoneMaxWidth, tabletMaxWidth, tabletMinWidth, widthToContainThreeItems, widthToContainTwoLowerLimit, widthToContainTwoUpperLimit,
    widthToContainZeroItemUpperLimit } from '@shared/constants/screen-variables';

@Component({
    selector: 'app-bookings-page',
    templateUrl: './bookings-page.component.html',
    styleUrls: ['./bookings-page.component.sass'],
})
export class BookingsPageComponent extends BaseComponent implements OnInit {
    public teamId?: number;

    public numberOfMembersToDisplay: number;

    public displayButton: boolean = false;

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

    private loadMeetings(meetingMemberRequest: IMeetingMembersRequest) {
        this.meetingService
            .getThreeMeetings(meetingMemberRequest)
            .pipe(this.untilThis)
            .subscribe(
                (resp: IMeetingBooking[]) => {
                    this.meetings = resp;
                },
                (error) => this.notifications.showErrorMessage(error),
            );
    }

    @HostListener('window:resize', ['$event'])
    onResize(event: Event) {
        const eventWindowTarget = event.target as Window;

        const width = eventWindowTarget.innerWidth;

        this.getNumberOfItemsToDisplayOnResize(width);
    }

    goToPage(pageName: string) {
        this.router.navigate([`${pageName}`]);
    }

    followMeetingLink(link: string) {
        window.open(link);
    }

    private getNumberOfItemsToDisplay() {
        const containerWidth = this.getPageSize();

        switch (true) {
            case containerWidth > desktopMaxWidth
            || (containerWidth < desktopMaxWidth && containerWidth > widthToContainThreeItems):
                this.numberOfMembersToDisplay = 4;
                break;
            case containerWidth < widthToContainThreeItems && containerWidth > widthToContainTwoUpperLimit:
                this.numberOfMembersToDisplay = 3;
                break;
            case containerWidth < widthToContainTwoUpperLimit && containerWidth > widthToContainTwoLowerLimit:
                this.numberOfMembersToDisplay = 2;
                break;
            case (containerWidth < widthToContainTwoLowerLimit && containerWidth > tabletMinWidth) || containerWidth < phoneMaxWidth:
                this.numberOfMembersToDisplay = 1;
                break;
            case containerWidth < tabletMinWidth && containerWidth > phoneMaxWidth:
                this.numberOfMembersToDisplay = 0;
                break;
            default:
                break;
        }
    }

    private getNumberOfItemsToDisplayOnResize(width: number) {
        if (width < desktopWidthToContainThreeItems) {
            this.numberOfMembersToDisplay = 3;
        }
        if (width > desktopWidthToContainFourItems) {
            this.numberOfMembersToDisplay = 4;
        }
        if (width < desktopWidthToContainTwoItems) {
            this.numberOfMembersToDisplay = 2;
        }
        if (width < tabletMaxWidth) {
            this.numberOfMembersToDisplay = 1;
        }
        if (width < widthToContainZeroItemUpperLimit) {
            this.numberOfMembersToDisplay = 0;
        }
    }

    private getPageSize(): number {
        const bookingContainer = (<HTMLElement> this.el.nativeElement)
            .querySelector('.container') as HTMLElement;

        return bookingContainer.offsetWidth;
    }
}
