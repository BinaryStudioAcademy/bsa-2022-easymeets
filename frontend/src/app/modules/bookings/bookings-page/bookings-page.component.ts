import { Component, ElementRef, EventEmitter, HostListener, OnDestroy, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { getDateFilters } from '@core/helpers/date-filter-helper';
import { addMinutesHelper, moveByTimezone } from '@core/helpers/date-helper';
import { getDefaultTimeZone } from '@core/helpers/time-zone-helper';
import { IMeetingBooking } from '@core/models/IMeetingBooking';
import { IMeetingMembersRequest } from '@core/models/IMeetingMemberRequest';
import { ConfirmationWindowService } from '@core/services/confirmation-window.service';
import { MeetingBookingsService } from '@core/services/meeting-bookings.service';
import { NotificationService } from '@core/services/notification.service';
import { TeamService } from '@core/services/team.service';
import {
    desktopWidthToContainFourItems,
    desktopWidthToContainTwoItems,
    phoneMaxWidth,
    tabletMaxWidth,
    widthToContainFiveItems,
    widthToContainThreeItems,
    widthToContainZeroItemUpperLimit,
} from '@shared/constants/screen-variables';
import { deletionMessage } from '@shared/constants/shared-messages';
import { DateFilterValue } from '@shared/enums/dateFilterValue';
import { LocationType } from '@shared/enums/locationType';
import { addDays } from 'date-fns';
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

    public locationTypeOffice = LocationType.Office;

    public currentDate = new Date();

    public currentStart: Date;

    public currentEnd: Date;

    public selectedDateFilter: DateFilterValue = DateFilterValue.Today;

    public possibleDateFilters = getDateFilters();

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
        this.currentStart = new Date(this.currentDate.getFullYear(), this.currentDate.getMonth(), this.currentDate.getDate());
        this.currentEnd = new Date(this.currentDate.getFullYear(), this.currentDate.getMonth(), this.currentDate.getDate() + 1);
        this.getBookings();
    }

    getBookings() {
        const containerWidth = this.getPageSize();

        this.getNumberOfItemsToDisplay(containerWidth);
        this.teamService.currentTeamEmitted$
            .subscribe(teamId => {
                this.teamId = teamId;

                this.loadMeetings(this.getMeetingRequest());
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
                    this.getBookings();
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
            .getMeetings(meetingMemberRequest)
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

    public currentDateChange() {
        const meetingRequest = this.getMeetingRequest();

        this.loadMeetings(meetingRequest);
    }

    private getMeetingRequest() {
        let meetingRequest: IMeetingMembersRequest = { teamId: this.teamId };

        if (this.selectedDateFilter === DateFilterValue.Today) {
            meetingRequest = {
                ...meetingRequest,
                start: moveByTimezone(new Date(this.currentDate.getFullYear(), this.currentDate.getMonth(), this.currentDate.getDate())),
                end: moveByTimezone(new Date(this.currentDate.getFullYear(), this.currentDate.getMonth(), this.currentDate.getDate() + 1)),
            };
        }

        if (this.selectedDateFilter === DateFilterValue.Past) {
            meetingRequest = {
                ...meetingRequest,
                end: moveByTimezone(new Date()),
            };
        }

        if (this.selectedDateFilter === DateFilterValue.Pending) {
            meetingRequest = {
                ...meetingRequest,
                start: moveByTimezone(new Date()),
            };
        }

        if (this.selectedDateFilter === DateFilterValue.Range) {
            if (!this.currentEnd || this.currentStart.getTime() === this.currentEnd.getTime()) {
                this.currentEnd = addDays(this.currentStart, 1);
            }
            meetingRequest = {
                ...meetingRequest,
                start: moveByTimezone(this.currentStart),
                end: moveByTimezone(this.currentEnd),
            };
        }

        return meetingRequest;
    }

    private getNumberOfItemsToDisplay(width: number) {
        if (width > widthToContainFiveItems) {
            this.numberOfMembersToDisplay = 5;

            return;
        }
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

    override ngOnDestroy(): void {
        super.ngOnDestroy();

        this.deleteEventSubscription.unsubscribe();
    }
}
