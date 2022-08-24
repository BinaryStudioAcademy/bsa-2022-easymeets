import { ChangeDetectionStrategy, Component } from '@angular/core';
import { CalendarEvent } from 'angular-calendar';
import { addDays, addHours, startOfDay } from 'date-fns';

@Component({
    selector: 'app-schedule-week',
    changeDetection: ChangeDetectionStrategy.OnPush,
    templateUrl: './schedule-week.component.html',
    styleUrls: ['./schedule-week.component.sass'],
})
export class ScheduleWeekComponent {
    viewDate: Date = new Date();

    events: CalendarEvent[] = [
        {
            start: addHours(startOfDay(new Date()), 5),
            end: addHours(startOfDay(new Date()), 17),
            title: 'Event 1',
            allDay: true,
        },
        {
            start: addHours(startOfDay(addDays(new Date(), 1)), 2),
            end: addHours(startOfDay(addDays(new Date(), 1)), 18),
            title: 'Event 2',
            allDay: true,
        },
        {
            start: addHours(startOfDay(new Date()), 8),
            title: 'Event 3',
            allDay: true,
        },
    ];
}
