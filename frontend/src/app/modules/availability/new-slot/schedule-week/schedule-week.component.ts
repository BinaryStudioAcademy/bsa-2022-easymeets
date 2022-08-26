import { ChangeDetectionStrategy, Component } from '@angular/core';
import { colors } from '@core/helpers/colors';
import { CalendarEvent, CalendarEventTimesChangedEvent, CalendarView } from 'angular-calendar';
import { addDays, addHours, setDay, startOfDay, subDays, subSeconds } from 'date-fns';
import { Subject } from 'rxjs';

@Component({
    selector: 'app-schedule-week',
    changeDetection: ChangeDetectionStrategy.OnPush,
    templateUrl: './schedule-week.component.html',
    styleUrls: ['./schedule-week.component.sass'],
})
export class ScheduleWeekComponent {
    view: CalendarView = CalendarView.Week;

    viewDate: Date = new Date();

    events: CalendarEvent[] = [
        {
            start: addHours(startOfDay(setDay(new Date(), 1)), 2),
            end: subSeconds(addHours(startOfDay(setDay(new Date(), 1)), 2.1), 1),
            title: '1',
            color: colors.blue,
            resizable: {
                beforeStart: true,
                afterEnd: true,
            },
        },
        {
            start: addHours(startOfDay(setDay(new Date(), 2)), 2),
            end: subSeconds(addHours(startOfDay(setDay(new Date(), 2)), 3), 1),
            title: '2',
            color: colors.blue,
            resizable: {
                beforeStart: true,
                afterEnd: true,
            },
        },
        {
            start: addHours(startOfDay(setDay(new Date(), 3)), 5),
            end: subSeconds(addHours(startOfDay(setDay(new Date(), 3)), 10), 1),
            title: '3',
            color: colors.blue,
            resizable: {
                beforeStart: true,
                afterEnd: true,
            },
        },
    ];

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
}
