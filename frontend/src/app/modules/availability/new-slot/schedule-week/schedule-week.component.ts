import { DatePipe } from '@angular/common';
import { ChangeDetectionStrategy, Component, EventEmitter, Input, OnInit } from '@angular/core';
import { BaseComponent } from '@core/base/base.component';
import { IScheduleItem } from '@core/models/schedule/IScheduleItem';
import { CalendarEvent, CalendarEventTimesChangedEvent, CalendarView } from 'angular-calendar';
import { addHours, addMinutes, isSameDay, setDay, startOfDay } from 'date-fns';
import { Subject } from 'rxjs';

@Component({
    selector: 'app-schedule-week',
    changeDetection: ChangeDetectionStrategy.OnPush,
    templateUrl: './schedule-week.component.html',
    styleUrls: ['./schedule-week.component.sass'],
})
export class ScheduleWeekComponent extends BaseComponent implements OnInit {
    constructor(private datePipe: DatePipe) {
        super();
    }

    @Input() items: IScheduleItem[];

    @Input() itemChange: EventEmitter<void> = new EventEmitter();

    view: CalendarView = CalendarView.Week;

    viewDate: Date = new Date();

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

    private createDate(weekDay: number, hours: string): Date {
        return addMinutes(addHours(
            startOfDay(setDay(new Date(), this.recalculateDayIndexForCalendar(weekDay))),
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

    private recalculateDayIndexForCalendar(weekDayIndex: number): number {
        let index = weekDayIndex;

        if (weekDayIndex < 6) {
            return ++index;
        }

        return 0;
    }

    private dateTimeFloor(now: Date): Date {
        const stepFloor = 300000;

        return new Date(Math.floor(new Date(now).getTime() / stepFloor) * stepFloor);
    }

    private timeToString(date: Date): string {
        return this.datePipe.transform(date, 'HH:mm:ss') ?? '';
    }
}
