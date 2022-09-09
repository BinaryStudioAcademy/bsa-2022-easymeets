import { WeekDay } from '@angular/common';
import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { changeScheduleItemsDate } from '@core/helpers/schedule-items-helper';
import { IAvailabilitySlot } from '@core/models/IAvailabilitySlot';
import { ICalendarWeek } from '@core/models/ICalendarWeek';
import { IOrderedMeetingTimes } from '@core/models/IOrderedMeetingTimes';
import { IScheduleItemReceive } from '@core/models/schedule/IScheduleItemsReceive';
import { AvailabilitySlotService } from '@core/services/availability-slot.service';
import { ExternalAttendeeService } from '@core/services/external-attendee.service';
import { NewMeetingService } from '@core/services/new-meeting.service';
import { SpinnerService } from '@core/services/spinner.service';
import { LocationType } from '@shared/enums/locationType';
import { addDays, addMinutes, subDays } from 'date-fns';
import { TZone } from 'moment-timezone-picker';

@Component({
    selector: 'app-external-booking-choose-time-page',
    templateUrl: './external-booking-choose-time-page.component.html',
    styleUrls: ['./external-booking-choose-time-page.component.sass'],
})
export class ExternalBookingTimeComponent extends BaseComponent implements OnInit {
    link: string;

    slot: IAvailabilitySlot | null;

    @Output() selectedDurationAndLocationEvent = new EventEmitter<{
        slotId: bigint;
        teamId?: bigint;
        duration: number;
        location: LocationType;
    }>();

    @Input() selectedMeetingDuration: number;

    @Output() selectedTimeAndDateEvent = new EventEmitter<{ date: Date; timeFinish: Date; timeZone: TZone }>();

    public slotsCount: Array<object>;

    public disabledDays: number[];

    public orderedTimes: IOrderedMeetingTimes[];

    public currentDay: Date;

    public scheduleItems: IScheduleItemReceive[];

    public theLatestFinishOfTimeRanges: Date;

    public theEarliestStartOfTimeRanges: Date;

    public pickedTimeZone: TZone;

    public calendarWeek: ICalendarWeek;

    public nowDate: Date = new Date(Date.now());

    constructor(
        public spinnerService: SpinnerService,
        private availabilitySlotService: AvailabilitySlotService,
        private meetingService: NewMeetingService,
        private externalService: ExternalAttendeeService,
        private route: ActivatedRoute,
    ) {
        super();
    }

    ngOnInit(): void {
        this.calendarWeek = this.getCurrentWeek();
        this.route.firstChild?.paramMap.subscribe((params) => {
            this.link = params.get('slotLink')!;
        });

        this.availabilitySlotService
            .getByLink(this.link)
            .pipe(this.untilThis)
            .subscribe((resp) => {
                this.slot = resp;
                this.addDurationAndLocation(this.slot!.id, this.slot!.teamId, this.slot!.size, this.slot!.locationType);
                this.getOrderedTimes(this.slot!.id);
                this.selectedMeetingDuration = this.slot!.size;
                this.scheduleItems = changeScheduleItemsDate(resp!.schedule!.scheduleItems);
                this.disabledDays = resp!
                    .schedule!.scheduleItems.filter((el) => !el.isEnabled)
                    .map((el) => WeekDay[el.weekDay]);
                this.slotsCount = this.slotsCounter();
            });
    }

    private getOrderedTimes(slotId: bigint) {
        this.meetingService
            .getOrderedMeetingTimes(slotId)
            .pipe(this.untilThis)
            .subscribe((result) => {
                this.orderedTimes = result;
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

    public AddTimeAndDate(timeIndex: number, dayIndex: number, timeZone: TZone): void {
        const date = addDays(this.calendarWeek.firstDay, dayIndex);
        const time = addMinutes(this.theEarliestStartOfTimeRanges, this.selectedMeetingDuration * timeIndex);

        date.setHours(time.getHours(), time.getMinutes(), time.getSeconds(), time.getMilliseconds());
        const timeFinish = new Date(time.getTime() + this.selectedMeetingDuration * 60000);

        this.selectedTimeAndDateEvent.emit({ date, timeFinish, timeZone });
    }

    public changeWeek(addingMode: boolean): void {
        this.calendarWeek = {
            ...this.calendarWeek,
            firstDay: addingMode ? addDays(this.calendarWeek.firstDay, 7) : subDays(this.calendarWeek.firstDay, 7),
            lastDay: addingMode ? addDays(this.calendarWeek.lastDay, 7) : subDays(this.calendarWeek.lastDay, 7),
        };
    }

    public isTodayDate(date: Date, daysToAdd: number = 0): boolean {
        const newDate = addDays(date, daysToAdd);

        return (
            newDate.getDate() === this.nowDate.getDate() &&
            newDate.getMonth() === this.nowDate.getMonth() &&
            newDate.getFullYear() === this.nowDate.getFullYear()
        );
    }

    public isDateInRange(date: Date, min: Date, max: Date, daysToAdd: number = 0, timesToAdd = 0): boolean {
        const firstCalendarDay = new Date(this.calendarWeek.firstDay);

        firstCalendarDay.setHours(date.getHours(), date.getMinutes(), date.getSeconds(), date.getMilliseconds());
        const result = addDays(firstCalendarDay, daysToAdd);

        result.setTime(result.getTime() + this.selectedMeetingDuration * timesToAdd * 60 * 1000);

        if (this.disabledDays.includes(result.getDay())) {
            return false;
        }

        const checkBookedDate = (parsedDate: Date) =>
            parsedDate.getDate() === result.getDate() && parsedDate.getTime() === result.getTime();

        if (this.orderedTimes.some((x) => checkBookedDate(new Date(Date.parse(x.startTime))))) {
            return false;
        }

        min.setDate(result.getDate());
        min.setMonth(result.getMonth());

        max.setDate(result.getDate());
        max.setMonth(result.getMonth());

        return (
            result.getTime() >= min.getTime() &&
            result.getTime() <= max.getTime() &&
            result.getTime() > this.nowDate.getTime()
        );
    }

    public isLastDate(date: Date, daysToAdd: number = 0): boolean {
        const newDate = addDays(date, daysToAdd);

        return (
            (newDate.getDate() >= this.nowDate.getDate() &&
                newDate.getMonth() === this.nowDate.getMonth() &&
                newDate.getFullYear() === this.nowDate.getFullYear()) ||
            (newDate.getMonth() > this.nowDate.getMonth() && newDate.getFullYear() >= this.nowDate.getFullYear())
        );
    }

    addDurationAndLocation(slotId: bigint, teamId: bigint | undefined, duration: number, location: LocationType) {
        this.selectedDurationAndLocationEvent.emit({ slotId, teamId, duration, location });
    }
}
