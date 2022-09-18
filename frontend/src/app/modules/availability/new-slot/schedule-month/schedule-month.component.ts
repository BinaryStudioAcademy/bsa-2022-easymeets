import { DatePipe } from '@angular/common';
import { Component, EventEmitter, Input, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { BaseComponent } from '@core/base/base.component';
import { CustomCalendarDateFormatter } from '@core/helpers/custom-calendar-date-formatter.provider';
import { TimeRangesMergeHelper } from '@core/helpers/time-ranges-merge-helper';
import { IExclusionDate } from '@core/models/schedule/exclusion-date/IExclusionDate';
import { IScheduleItem } from '@core/models/schedule/IScheduleItem';
import {
    ExclusionDatesPickerComponent,
} from '@modules/exclusion-dates/exclusion-dates-picker/exclusion-dates-picker.component';
import { WeekDay } from '@shared/enums/weekDay';
import {
    CalendarDateFormatter,
    CalendarEvent,
    CalendarEventTimesChangedEvent,
    CalendarMonthViewDay,
} from 'angular-calendar';
import { addHours, addMinutes, isSameDay, setDay, startOfDay } from 'date-fns';
import { Subject } from 'rxjs';

@Component({
    selector: 'app-schedule-month',
    templateUrl: './schedule-month.component.html',
    styleUrls: ['./schedule-month.component.sass'],
    providers: [
        {
            provide: CalendarDateFormatter,
            useClass: CustomCalendarDateFormatter,
        },
    ],
})
export class ScheduleMonthComponent extends BaseComponent implements OnInit {
    @Input() items: IScheduleItem[];

    @Input() itemChange: EventEmitter<void> = new EventEmitter();

    viewDate: Date = new Date();

    constructor(private dialog: MatDialog, private datePipe: DatePipe) {
        super();
    }

    events: CalendarEvent[];

    refresh = new Subject<void>();

    ngOnInit(): void {
        this.updateEvents();

        this.itemChange
            .pipe(this.untilThis)
            .subscribe(() => {
                this.updateEvents();
            });
    }

    getWeekScheduleTime(date: Date): string | null {
        const weekDay = this.getWeekDay(date);
        const scheduleItems = this.items.filter(item => item.weekDay === weekDay && item.isEnabled);

        if (scheduleItems.length === 0) {
            return null;
        }

        return `${scheduleItems[0].start.substring(0, 5)}-${scheduleItems[0].end.substring(0, 5)}`;
    }

    eventTimesChanged(changedEvent: CalendarEventTimesChangedEvent): void {
        changedEvent.event.start = this.dateTimeFloor(changedEvent.newStart);
        changedEvent.event.end = this.dateTimeFloor(changedEvent.newEnd!);

        const item = this.items.find(i => i.weekDay === changedEvent.event.id);

        if (item) {
            item.start = this.timeToString(changedEvent.event.start);
            item.end = this.timeToString(changedEvent.event.end!);
            this.itemChange.emit();
            this.refresh.next();
        }
    }

    validateEventTimesChanged = (changedEvent: CalendarEventTimesChangedEvent) => {
        if (changedEvent.newEnd) {
            delete changedEvent.event.cssClass;
            const sameDay = isSameDay(changedEvent.newStart, changedEvent.newEnd);

            if (!sameDay) {
                return false;
            }
        }

        return true;
    };

    private updateEvents() {
        this.events = this.items
            .filter(item => item.isEnabled)
            .map((item) => ({
                start: this.createDate(item.weekDay, item.start),
                end: this.createDate(item.weekDay, item.end),
                title: '',
                resizable: {
                    beforeStart: true,
                    afterEnd: true,
                },
                id: item.weekDay,
            }));
        this.refresh.next();
    }

    private createDate(weekDay: WeekDay, hours: string): Date {
        return addMinutes(addHours(
            startOfDay(setDay(new Date(), Object.keys(WeekDay).indexOf(weekDay))),
            this.parseTime(hours).getHours(),
        ), this.parseTime(hours).getMinutes());
    }

    private parseTime(time: string): Date {
        const d = new Date();
        const [hours, minutes, seconds] = time.split(':');

        d.setHours(+hours);
        d.setMinutes(+minutes);
        d.setSeconds(+seconds);

        return d;
    }

    private dateTimeFloor(now: Date): Date {
        const stepFloor = 300000;

        return new Date(Math.floor(new Date(now).getTime() / stepFloor) * stepFloor);
    }

    private timeToString(date: Date): string {
        return this.datePipe.transform(date, 'HH:mm:ss') ?? '';
    }

    private getWeekDay(date: Date): string {
        return this.datePipe.transform(date, 'EEEE') ?? '';
    }

    beforeMonthViewRender({ body }: { body: CalendarMonthViewDay[] }): void {
        body.forEach((day) => {
            day.badgeTotal = day.events.filter(
                (event) => event.meta.incrementsBadgeTotal,
            ).length;
        });
    }

    showExclusionDatesWindow() {
        this.dialog
            .open<ExclusionDatesPickerComponent, IExclusionDate, IExclusionDate | undefined>(ExclusionDatesPickerComponent)
            .afterClosed()
            .subscribe((newExclusionDate) => {
                if (newExclusionDate) {
                    // this.sortDayTimeRanges(newExclusionDate.dayTimeRanges);
                    newExclusionDate.dayTimeRanges = TimeRangesMergeHelper(newExclusionDate.dayTimeRanges);

                    // if (!this.mergeExistingExclusionDates(newExclusionDate)) {
                    //     this.scheduleValue.exclusionDates = [...this.scheduleValue.exclusionDates, newExclusionDate];
                    // }
                }
            });
    }
}
