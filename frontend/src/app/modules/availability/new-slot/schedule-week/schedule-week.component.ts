import { ChangeDetectionStrategy, Component, Input, OnInit } from '@angular/core';
import { colors } from '@core/helpers/colors';
import { IScheduleItem } from '@core/models/schedule/IScheduleItem';
import { CalendarEvent, CalendarEventTimesChangedEvent, CalendarView } from 'angular-calendar';
import { addHours, addMinutes, setDay, startOfDay } from 'date-fns';
import { Subject } from 'rxjs';

@Component({
    selector: 'app-schedule-week',
    changeDetection: ChangeDetectionStrategy.OnPush,
    templateUrl: './schedule-week.component.html',
    styleUrls: ['./schedule-week.component.sass'],
})
export class ScheduleWeekComponent implements OnInit {
    @Input() public items: IScheduleItem[];

    @Input() public displayDay: string;

    ngOnInit(): void {
        this.events = [];
        this.items.forEach((item) => {
            this.events = this.events.concat({
                start: addMinutes(addHours(
                    startOfDay(setDay(new Date(), item.weekDay)),
                    this.parseTime(item.start).getHours(),
                ), this.parseTime(item.start).getMinutes()),
                end: addMinutes(addHours(
                    startOfDay(setDay(new Date(), item.weekDay)),
                    this.parseTime(item.end).getHours(),
                ), this.parseTime(item.end).getMinutes()),
                title: '1',
                color: colors.blue,
                resizable: {
                    beforeStart: true,
                    afterEnd: true,
                },
            });
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
        event.end = newEnd;
        this.refresh.next();
    }

    parseTime(time: string): Date {
        const d = new Date();
        const [hours, minutes, seconds] = time.split(':');

        d.setHours(+hours);
        d.setMinutes(+minutes);
        d.setSeconds(+seconds);

        return d;
    }
}
