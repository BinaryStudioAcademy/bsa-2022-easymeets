import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { changeScheduleItemsDate } from '@core/helpers/schedule-items-helper';
import { IAvailabilitySlot } from '@core/models/IAvailabilitySlot';
import { ICalendarWeek } from '@core/models/ICalendarWeek';
import { IScheduleItemReceive } from '@core/models/schedule/IScheduleItemsReceive';
import { AvailabilitySlotService } from '@core/services/availability-slot.service';
import { SpinnerService } from '@core/services/spinner.service';
import { LocationType } from '@shared/enums/locationType';
import { TimeZone } from '@shared/enums/timeZone';

@Component({
    selector: 'app-external-booking-choose-time-page',
    templateUrl: './external-booking-choose-time-page.component.html',
    styleUrls: ['./external-booking-choose-time-page.component.sass'],
})
export class ExternalBookingTimeComponent extends BaseComponent implements OnInit {
    link: string;

    slot: IAvailabilitySlot | null;

    @Output() selectedDurationAndLocationEvent = new EventEmitter<{
        duration: number;
        location: LocationType;
    }>();

    @Input() selectedMeetingDuration: number;

    @Output() selectedTimeAndDateEvent = new EventEmitter<{ date: Date; timeFinish: Date }>();

    public slotsCount: Array<object>;

    public currentDay: Date;

    public scheduleItems: IScheduleItemReceive[];

    public theLatestFinishOfTimeRanges: Date;

    public theEarliestStartOfTimeRanges: Date;

    public timeZone = TimeZone;

    public pickedTimeZone: TimeZone;

    public calendarWeek: ICalendarWeek;

    public nowDate: Date = new Date(Date.now());

    constructor(
        public spinnerService: SpinnerService,
        private availabilitySlotService: AvailabilitySlotService,
        private route: ActivatedRoute,
    ) {
        super();
    }

    ngOnInit(): void {
        this.calendarWeek = this.getCurrentWeek();
        this.route.queryParams.subscribe((params) => {
            this.link = params['link'];
        });

        this.availabilitySlotService
            .getByLink(this.link)
            .pipe(this.untilThis)
            .subscribe((resp) => {
                this.slot = resp;
                this.addDurationAndLocation(this.slot!.size, this.slot!.locationType);
                this.selectedMeetingDuration = this.slot!.size;
                this.scheduleItems = changeScheduleItemsDate(resp!.schedule!.scheduleItems);
                this.slotsCount = this.slotsCounter();
            });
    }

    private slotsCounter(): Array<object> {
        this.theLatestFinishOfTimeRanges = this.scheduleItems[0]?.end;
        this.theEarliestStartOfTimeRanges = this.scheduleItems[0]?.start;

        this.scheduleItems.forEach((day) => {
            if (day.end > this.theLatestFinishOfTimeRanges) {
                this.theLatestFinishOfTimeRanges = day.end;
            }
            if (day.start < this.theEarliestStartOfTimeRanges) {
                this.theEarliestStartOfTimeRanges = day.start;
            }
        });

        const theLongestHoursRange: number =
            this.theLatestFinishOfTimeRanges.getHours() - this.theEarliestStartOfTimeRanges.getHours();

        return new Array(Math.ceil((theLongestHoursRange * 60) / this.selectedMeetingDuration + 1));
    }

    private getCurrentWeek(): ICalendarWeek {
        const current = new Date();
        let currentMonth = current.getMonth();
        const first = current.getDate() - current.getDay();
        const last = first + 6;

        const firstDay: Date = new Date(new Date().setDate(first));
        const lastDay: Date = new Date(new Date().setDate(last));

        if (first < 0) {
            lastDay.setMonth(currentMonth);
            currentMonth--;
            firstDay.setMonth(currentMonth);
        }

        const week: ICalendarWeek = { firstDay, lastDay };

        return week;
    }

    public AddTimeAndDate(timeIndex: number, dayIndex: number): void {
        const selectedDay = this.calendarWeek.firstDay.getTime() + dayIndex * 24 * 60 * 60 * 1000;
        const selectedTime =
            this.theEarliestStartOfTimeRanges.getTime() + this.selectedMeetingDuration * timeIndex * 60000;
        const date = new Date(selectedDay);
        const time = new Date(selectedTime);

        date.setHours(time.getHours());
        date.setMinutes(time.getSeconds());
        const timeFinish = new Date(time.getTime() + this.selectedMeetingDuration * 60000);

        this.selectedTimeAndDateEvent.emit({ date, timeFinish });
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
        const current = new Date();
        let currentMonth = current.getMonth();
        const first = current.getDate() - current.getDay();

        const firstDay: Date = new Date(new Date().setDate(first));

        if (first < 0) {
            currentMonth--;
            firstDay.setMonth(currentMonth);
        }

        const newDate = new Date(firstDay.setDate(date.getDate() + daysToAdd));

        return (
            newDate.getDate() === this.nowDate.getDate() &&
            newDate.getMonth() === this.nowDate.getMonth() &&
            newDate.getFullYear() === this.nowDate.getFullYear()
        );
    }

    public isDateInRange(date: Date, min: Date, max: Date, daysToAdd: number = 0): boolean {
        return (
            date.getTime() + this.selectedMeetingDuration * daysToAdd * 60 * 1000 >= min.getTime() &&
            date.getTime() + this.selectedMeetingDuration * daysToAdd * 60 * 1000 <= max.getTime()
        );
    }

    public isLastDate(date: Date, daysToAdd: number = 0): boolean {
        const firstWeekDay = this.calendarWeek.firstDay;
        let currentMonth = firstWeekDay.getMonth();
        const first = firstWeekDay.getDate() - firstWeekDay.getDay();

        const firstDay: Date = new Date(firstWeekDay.setDate(first));

        if (first < 0) {
            currentMonth--;
            firstDay.setMonth(currentMonth);
        }

        const newDate = new Date(firstDay.setDate(date.getDate() + daysToAdd));

        return (
            (newDate.getDate() >= this.nowDate.getDate() &&
                newDate.getMonth() === this.nowDate.getMonth() &&
                newDate.getFullYear() === this.nowDate.getFullYear()) ||
            (newDate.getMonth() > this.nowDate.getMonth() && newDate.getFullYear() >= this.nowDate.getFullYear())
        );
    }

    addDurationAndLocation(duration: number, location: LocationType) {
        this.selectedDurationAndLocationEvent.emit({ duration, location });
    }
}
