import { Component, ElementRef, EventEmitter, HostListener, OnDestroy, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { getDateFilters } from '@core/helpers/date-filter-helper';
import { addMinutesHelper, moveByTimezone } from '@core/helpers/date-helper';
import { LocationTypeMapping } from '@core/helpers/location-type-mapping';
import { getCurrentDate, getDefaultTimeZone } from '@core/helpers/time-zone-helper';
import { IMeetingBooking } from '@core/models/IMeetingBooking';
import { IMeetingMembersRequest } from '@core/models/IMeetingMemberRequest';
import { ConfirmationWindowService } from '@core/services/confirmation-window.service';
import { MeetingBookingsService } from '@core/services/meeting-bookings.service';
import { NotificationService } from '@core/services/notification.service';
import { SpinnerService } from '@core/services/spinner.service';
import { TeamService } from '@core/services/team.service';
import { phoneMaxWidth } from '@shared/constants/screen-variables';
import { deletionMessage } from '@shared/constants/shared-messages';
import { DateFilterValue } from '@shared/enums/dateFilterValue';
import { LocationType } from '@shared/enums/locationType';
import { endOfDay, startOfDay } from 'date-fns';
import { concatMap, map, Subscription } from 'rxjs';

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

    public currentDate = getCurrentDate();

    public currentStart: Date;

    public currentEnd: Date;

    public selectedDateFilter: DateFilterValue = DateFilterValue.Today;

    public possibleDateFilters = getDateFilters();

    public maxAvatarNumber: number = 10;

    public slotWidth = 250;

    public infoWidth = 280;

    public containerPadding = 100;

    constructor(
        private el: ElementRef,
        private meetingService: MeetingBookingsService,
        private router: Router,
        private notifications: NotificationService,
        private teamService: TeamService,
        private confirmWindowService: ConfirmationWindowService,
        private spinnerService: SpinnerService,
    ) {
        super();
        this.meetings = [];
        this.deleteEventSubscription = this.deleteEventEmitter.subscribe(() => this.deleteBooking());
    }

    public ngOnInit(): void {
        this.currentStart = startOfDay(this.currentDate);
        this.currentEnd = endOfDay(this.currentDate);
        this.getBookings();
    }

    getBookings() {
        this.spinnerService.show();
        const containerWidth = this.getPageSize();

        this.getNumberOfItemsToDisplay(containerWidth);
        this.teamService.currentTeamEmitted$
            .pipe(
                this.untilThis,
                concatMap((teamId) => {
                    this.teamId = teamId;

                    return this.loadMeetings();
                }),
            )
            .subscribe(() => this.spinnerService.hide());
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
        this.spinnerService.show();
        this.meetingService
            .deleteBooking(this.currentBookingId)
            .pipe(this.untilThis)
            .subscribe({
                next: () => {
                    this.spinnerService.hide();
                    this.notifications.showSuccessMessage('Meeting was successfully deleted');
                    this.getBookings();
                },
                error: (error) => {
                    this.notifications.showErrorMessage(error);
                },
            });
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

    private loadMeetings() {
        return this.meetingService.getMeetings(this.getMeetingRequest()).pipe(
            this.untilThis,
            map((resp: IMeetingBooking[]) => {
                this.meetings = resp;
            }),
        );
    }

    getEndMeetingDate(date: Date, duration: number) {
        return addMinutesHelper(date, duration);
    }

    getTimeZoneValue() {
        return getDefaultTimeZone().timeValue;
    }

    currentDateChange() {
        this.loadMeetings().subscribe();
    }

    locationTypeMapping = LocationTypeMapping;

    private getMeetingRequest(): IMeetingMembersRequest {
        const range = this.getMeetingsRange();

        return { teamId: this.teamId, start: range?.start, end: range?.end };
    }

    private getMeetingsRange() {
        switch (this.selectedDateFilter) {
            case DateFilterValue.Today: {
                return {
                    start: moveByTimezone(startOfDay(this.currentDate)),
                    end: moveByTimezone(endOfDay(this.currentDate)),
                };
            }
            case DateFilterValue.Past: {
                return {
                    end: moveByTimezone(this.currentDate),
                };
            }
            case DateFilterValue.Pending: {
                return {
                    start: moveByTimezone(this.currentDate),
                };
            }
            case DateFilterValue.Range: {
                return {
                    start: moveByTimezone(this.currentStart),
                    end: moveByTimezone(endOfDay(this.currentEnd ?? this.currentStart)),
                };
            }
            default: {
                return undefined;
            }
        }
    }

    private getNumberOfItemsToDisplay(width: number) {
        this.numberOfMembersToDisplay =
            width > phoneMaxWidth
                ? Math.floor((width - 2 * this.containerPadding - this.infoWidth) / this.slotWidth)
                : 1;
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
