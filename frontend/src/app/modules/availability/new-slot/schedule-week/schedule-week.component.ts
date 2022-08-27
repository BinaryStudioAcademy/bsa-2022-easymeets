import { ChangeDetectionStrategy, Component, EventEmitter, Input, OnInit } from '@angular/core';
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
export class ScheduleWeekComponent implements OnInit {
    @Input() public items: IScheduleItem[];

    @Input() public itemChange: EventEmitter<void> = new EventEmitter();

    ngOnInit(): void {
        this.updateEvents();

        this.itemChange.subscribe(() => {
            this.updateEvents();
        });
    }

    view: CalendarView = CalendarView.Week;

    viewDate: Date = new Date();

    events: CalendarEvent[];

    refresh = new Subject<void>();

    eventTimesChanged({
        event,
        newStart,
        newEnd,
    }: CalendarEventTimesChangedEvent): void {
        event.start = newStart;
        event.end = newEnd as Date;
        const index = this.events.indexOf(event);

        this.items[index].start = `${this.reformat(newStart.getHours())}:${this.reformat(newStart.getMinutes())}:00`;
        if (newEnd !== undefined) {
            this.items[index].end = `${this.reformat(newEnd.getHours())}:${this.reformat(newEnd.getMinutes())}:00`;
        }
        this.itemChange.emit();
        this.refresh.next();
    }

    reformat(num: number): string {
        if (num < 10) {
            return `0${num}`;
        }

        return num.toString();
    }

    parseTime(time: string): Date {
        const d = new Date();
        const [hours, minutes, seconds] = time.split(':');

        d.setHours(+hours);
        d.setMinutes(+minutes);
        d.setSeconds(+seconds);

        return d;
    }

    private updateEvents() {
        let events: CalendarEvent[] = [];

        this.items.forEach((item) => {
            if (item.isEnabled) {
                events = events.concat({
                    start: addMinutes(addHours(
                        startOfDay(setDay(new Date(), item.weekDay)),
                        this.parseTime(item.start).getHours(),
                    ), this.parseTime(item.start).getMinutes()),
                    end: addMinutes(addHours(
                        startOfDay(setDay(new Date(), item.weekDay)),
                        this.parseTime(item.end).getHours(),
                    ), this.parseTime(item.end).getMinutes()),
                    title: '',
                    resizable: {
                        beforeStart: true,
                        afterEnd: true,
                    },
                });
            }
        });

        this.events = events;
        this.refresh.next();
    }

    validateEventTimesChanged = (
        { event, newStart, newEnd }: CalendarEventTimesChangedEvent,
    ) => {
        if (newEnd !== undefined) {
            delete event.cssClass;
            const sameDay = isSameDay(newStart, newEnd);

            if (!sameDay) {
                return false;
            }
        }

        return true;
    };
}
