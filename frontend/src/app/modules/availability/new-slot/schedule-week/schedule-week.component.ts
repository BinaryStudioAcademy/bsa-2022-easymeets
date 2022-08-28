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
    @Input() public items: IScheduleItem[];

    @Input() public itemChange: EventEmitter<void> = new EventEmitter();

    public view: CalendarView = CalendarView.Week;

    public viewDate: Date = new Date();

    public events: CalendarEvent[];

    public refresh = new Subject<void>();

    public ngOnInit(): void {
        this.updateEvents();

        this.itemChange
            .pipe(this.untilThis)
            .subscribe(() => {
                this.updateEvents();
            });
    }

    public eventTimesChanged({
        event,
        newStart,
        newEnd,
    }: CalendarEventTimesChangedEvent): void {
        event.start = newStart;
        event.end = newEnd;
        const item = this.items.find(i => i.weekDay === event.id);

        if (item) {
            item.start = `${this.reformat(newStart.getHours())}:${this.reformat(newStart.getMinutes())}:00`;
            if (newEnd) {
                item.end = `${this.reformat(newEnd.getHours())}:${this.reformat(newEnd.getMinutes())}:00`;
            }
            this.itemChange.emit();
            this.refresh.next();
        }
    }

    public validateEventTimesChanged = (
        { event, newStart, newEnd }: CalendarEventTimesChangedEvent,
    ) => {
        if (newEnd) {
            delete event.cssClass;
            const sameDay = isSameDay(newStart, newEnd);

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
            startOfDay(setDay(new Date(), this.recalculateDayIndexForCalenfar(weekDay))),
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

    private reformat(num: number): string {
        if (num < 10) {
            return `0${num}`;
        }

        return num.toString();
    }

    private recalculateDayIndexForCalenfar(weekDayIndex: number): number {
        if (weekDayIndex < 6) {
            return ++weekDayIndex;
        }

        return 0;
    }
}
