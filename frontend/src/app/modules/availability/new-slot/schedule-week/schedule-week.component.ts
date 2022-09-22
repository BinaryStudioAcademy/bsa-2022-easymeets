import { ChangeDetectionStrategy, Component, EventEmitter, Input, OnInit, ViewEncapsulation } from '@angular/core';
import { BaseComponent } from '@core/base/base.component';
import { CustomCalendarDateFormatter } from '@core/helpers/custom-calendar-date-formatter.provider';
import { dateToTimeSpan } from '@core/helpers/schedule-items-helper';
import { ISchedule } from '@core/models/schedule/ISchedule';
import { ITimeSpan } from '@core/models/schedule/ITimeSpan';
import { WeekDay } from '@shared/enums/weekDay';
import { CalendarDateFormatter, CalendarEvent, CalendarEventTimesChangedEvent, CalendarView } from 'angular-calendar';
import { addHours, addMinutes, isSameDay, setDay, startOfDay } from 'date-fns';
import { Subject } from 'rxjs';

@Component({
    selector: 'app-schedule-week',
    changeDetection: ChangeDetectionStrategy.OnPush,
    templateUrl: './schedule-week.component.html',
    styleUrls: ['./schedule-week.component.sass'],
    providers: [
        {
            provide: CalendarDateFormatter,
            useClass: CustomCalendarDateFormatter,
        },
    ],
    encapsulation: ViewEncapsulation.None,
})
export class ScheduleWeekComponent extends BaseComponent implements OnInit {
    @Input() schedule: ISchedule;

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

        const item = this.schedule.scheduleItems.find(i => i.weekDay === changedEvent.event.id);

        if (item) {
            item.start = dateToTimeSpan(changedEvent.event.start);
            item.end = dateToTimeSpan(changedEvent.event.end!);
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
        this.events = this.schedule.scheduleItems
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

    private createDate(weekDay: WeekDay, timeSpan: ITimeSpan): Date {
        return addMinutes(addHours(startOfDay(setDay(new Date(), Object.keys(WeekDay).indexOf(weekDay))), timeSpan.hour), timeSpan.minute);
    }

    private dateTimeFloor(now: Date): Date {
        const stepFloor = 300000;

        return new Date(Math.floor(new Date(now).getTime() / stepFloor) * stepFloor);
    }
}
