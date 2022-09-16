import { Component } from '@angular/core';
import { CustomCalendarDateFormatter } from '@core/helpers/custom-calendar-date-formatter.provider';
import { CalendarDateFormatter, CalendarEvent, CalendarMonthViewDay } from 'angular-calendar';

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
export class ScheduleMonthComponent {
    viewDate: Date = new Date();

    events: CalendarEvent<{ incrementsBadgeTotal: boolean }>[] = [
        {
            title: 'Increments badge total on the day cell',
            start: new Date(),
            meta: {
                incrementsBadgeTotal: true,
            },
        },
        {
            title: 'Does not increment the badge total on the day cell',
            start: new Date(),
            meta: {
                incrementsBadgeTotal: false,
            },
        },
    ];

    beforeMonthViewRender({ body }: { body: CalendarMonthViewDay[] }): void {
        body.forEach((day) => {
            day.badgeTotal = day.events.filter(
                (event) => event.meta.incrementsBadgeTotal,
            ).length;
        });
    }
}
