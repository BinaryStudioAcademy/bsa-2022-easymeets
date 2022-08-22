import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { getExternalBookingTimeSlotsItems } from '@core/helpers/external-booking-time-slots-helper';
import { ICalendarWeek } from '@core/models/ICalendarWeek';
import { IDayTimeSlot } from '@core/models/IDayTimeSlot';
import { IUserPersonalAndTeamSlots } from '@core/models/IUserPersonalAndTeamSlots';
import { AvailabilitySlotService } from '@core/services/availability-slot.service';
import { SpinnerService } from '@core/services/spinner.service';
import { TimeZone } from '@shared/enums/timeZone';

@Component({
    selector: 'app-external-booking-choose-time-page',
    templateUrl: './external-booking-choose-time-page.component.html',
    styleUrls: ['./external-booking-choose-time-page.component.sass'],
})
export class ExternalBookingChooseTimeComponent extends BaseComponent implements OnInit {
    @Input() selectedUserId: number;

    public selectedUserAvailabilitySlots: IUserPersonalAndTeamSlots;

    public daysWithTimeRange: IDayTimeSlot[] = getExternalBookingTimeSlotsItems();

    @Input() selectedMeetingDuration: number;

    public slotsCount: Array<object>;

    public theLatestFinishOfTimeRanges: Date;

    public theEarliestStartOfTimeRanges: Date;

    public timeZone = TimeZone;

    public calendarWeek: ICalendarWeek;

    public nowDate: Date = new Date(Date.now());

    constructor(
        public spinnerService: SpinnerService,
        private availabilitySlotService: AvailabilitySlotService,
        private route: ActivatedRoute,
    ) {
        super();
        this.availabilitySlotService
            .getUserPersonalAndTeamSlots(this.selectedUserId)
            .pipe(this.untilThis)
            .subscribe((slots) => {
                this.selectedUserAvailabilitySlots = slots;
            });
    }

    ngOnInit(): void {
        this.calendarWeek = this.getCurrentWeek();
        this.route.queryParams.subscribe((params) => {
            this.selectedMeetingDuration = params['duration'];
        });
        this.slotsCount = this.slotsCounter();
    }

    private slotsCounter(): Array<object> {
        this.theLatestFinishOfTimeRanges = this.daysWithTimeRange[0].finishTime;
        this.theEarliestStartOfTimeRanges = this.daysWithTimeRange[0].startTime;

        this.daysWithTimeRange.forEach((day) => {
            if (day.finishTime > this.theLatestFinishOfTimeRanges) {
                this.theLatestFinishOfTimeRanges = day.finishTime;
            }
            if (day.startTime < this.theEarliestStartOfTimeRanges) {
                this.theEarliestStartOfTimeRanges = day.startTime;
            }
        });

        const theLongestHoursRange: number =
            this.theLatestFinishOfTimeRanges.getHours() - this.theEarliestStartOfTimeRanges.getHours();

        return new Array(Math.ceil((theLongestHoursRange * 60) / this.selectedMeetingDuration + 1));
    }

    private getCurrentWeek(): ICalendarWeek {
        const current = new Date();
        const first = current.getDate() - current.getDay() + 1;
        const last = first + 6;

        const firstDay: Date = new Date(current.setDate(first));
        const lastDay: Date = new Date(current.setDate(last));

        const week: ICalendarWeek = { firstDay, lastDay };

        return week;
    }

    public changeWeek(addingMode: boolean): void {
        if (addingMode) {
            this.calendarWeek.firstDay = new Date(
                this.calendarWeek.firstDay.setDate(this.calendarWeek.firstDay.getDate() + 7),
            );
            this.calendarWeek.lastDay = new Date(
                this.calendarWeek.lastDay.setDate(this.calendarWeek.lastDay.getDate() + 7),
            );
        } else {
            this.calendarWeek.firstDay = new Date(
                this.calendarWeek.firstDay.setDate(this.calendarWeek.firstDay.getDate() - 7),
            );
            this.calendarWeek.lastDay = new Date(
                this.calendarWeek.lastDay.setDate(this.calendarWeek.lastDay.getDate() - 7),
            );
        }
    }

    public isTodayDate(date: Date, daysToAdd: number = 0): boolean {
        return (
            date.getDate() + daysToAdd === this.nowDate.getDate() &&
            date.getMonth() === this.nowDate.getMonth() &&
            date.getFullYear() === this.nowDate.getFullYear()
        );
    }

    public isDateInRange(date: Date, min: Date, max: Date, daysToAdd: number = 0): boolean {
        return (
            date.getTime() + this.selectedMeetingDuration * daysToAdd * 60 * 1000 >= min.getTime() &&
            date.getTime() + this.selectedMeetingDuration * daysToAdd * 60 * 1000 <= max.getTime()
        );
    }

    public isLastDate(date: Date, daysToAdd: number = 0): boolean {
        return (
            (date.getDate() + daysToAdd >= this.nowDate.getDate() &&
                date.getMonth() === this.nowDate.getMonth() &&
                date.getFullYear() === this.nowDate.getFullYear()) ||
            (date.getMonth() > this.nowDate.getMonth() && date.getFullYear() >= this.nowDate.getFullYear())
        );
    }
}
