import { Component, ElementRef, EventEmitter, HostListener, OnDestroy, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { addMinutesHelper } from '@core/helpers/date-helper';
import { getDefaultTimeZone } from '@core/helpers/time-zone-helper';
import { IMeetingBooking } from '@core/models/IMeetingBooking';
import { IMeetingMembersRequest } from '@core/models/IMeetingMemberRequest';
import { ConfirmationWindowService } from '@core/services/confirmation-window.service';
import { MeetingBookingsService } from '@core/services/meeting-bookings.service';
import { NotificationService } from '@core/services/notification.service';
import { TeamService } from '@core/services/team.service';
import { desktopWidthToContainFourItems, desktopWidthToContainTwoItems, phoneMaxWidth, tabletMaxWidth,
    widthToContainThreeItems, widthToContainZeroItemUpperLimit } from '@shared/constants/screen-variables';
import { deletionMessage } from '@shared/constants/shared-messages';
import { Subscription } from 'rxjs';

@Component({
    selector: 'app-bookings-page',
    templateUrl: './bookings-page.component.html',
    styleUrls: ['./bookings-page.component.sass'],
})
export class BookingsPageComponent extends BaseComponent implements OnInit, OnDestroy {
    public teamId?: number;

    public numberOfMembersToDisplay: number;

    public meetings: IMeetingBooking[];

    public cachedMeetings: IMeetingBooking[];

    private deleteEventEmitter = new EventEmitter<void>();

    private deleteEventSubscription: Subscription;

    private currentBookingId: number;

    constructor(
        private el: ElementRef,
        private meetingService: MeetingBookingsService,
        private router: Router,
        private notifications: NotificationService,
        private teamService: TeamService,
        private confirmWindowService: ConfirmationWindowService,
    ) {
        super();
        this.meetings = [];
        this.deleteEventSubscription = this.deleteEventEmitter.subscribe(() => this.deleteBooking());
    }

    public ngOnInit(): void {
        this.getBookings();
    }

    override ngOnDestroy(): void {
        super.ngOnDestroy();

        this.deleteEventSubscription.unsubscribe();
    }

    getBookings() {
        const containerWidth = this.getPageSize();

        this.getNumberOfItemsToDisplay(containerWidth);
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

    deleteButtonClick(id: number) {
        this.currentBookingId = id;

        this.confirmWindowService.openConfirmDialog({
            buttonsOptions: [
                {
                    class: 'confirm-accept-button',
                    label: 'Yes',
                    onClickEvent: this.deleteEventEmitter,
                },
                {
                    class: 'confirm-cancel-button',
                    label: 'Cancel',
                    onClickEvent: new EventEmitter<void>(),
                },
            ],
            title: 'Confirm Meeting Deletion',
            message: deletionMessage,
        });
    }

    deleteBooking() {
        this.meetingService
            .deleteBooking(this.currentBookingId)
            .pipe(this.untilThis)
            .subscribe(
                () => {
                    this.notifications.showSuccessMessage('Meeting was successfully deleted');
                    this.reloadBookings();
                },
                (error) => {
                    this.notifications.showErrorMessage(error);
                },
            );
    }

    @HostListener('window:resize', ['$event'])
    onResize(event: Event) {
        const eventWindowTarget = event.target as Window;

        const width = eventWindowTarget.innerWidth;

        this.getNumberOfItemsToDisplay(width);
    }

    goToPage(pageName: string) {
        this.router.navigate([`${pageName}`]);
    }

    followMeetingLink(link: string) {
        window.open(link);
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

    getEndMeetingDate(date: Date, duration: number) {
        return addMinutesHelper(date, duration);
    }

    getTimeZoneValue() {
        return getDefaultTimeZone().timeValue;
    }

    private getNumberOfItemsToDisplay(width: number) {
        if (width > desktopWidthToContainFourItems) {
            this.numberOfMembersToDisplay = 4;
        }
        if (width < widthToContainThreeItems) {
            this.numberOfMembersToDisplay = 3;
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
        if (width < phoneMaxWidth) {
            this.numberOfMembersToDisplay = 1;
        }
    }

    private getPageSize(): number {
        const bookingContainer = this.el.nativeElement.getElementsByClassName('container')[0] as HTMLElement;

        return bookingContainer.offsetWidth;
    }

    private reloadBookings() {
        this.getBookings();
    }
}
