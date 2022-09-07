import { Component, EventEmitter, Input, Output, ViewEncapsulation } from '@angular/core';
import { BaseComponent } from '@core/base/base.component';
import { CustomCalendarDateFormatter } from '@core/helpers/custom-calendar-date-formatter.provider';
import { IDuration } from '@core/models/IDuration';
import { IUnavailability } from '@core/models/IUnavailability';
import { NotificationService } from '@core/services/notification.service';
import { CalendarDateFormatter, CalendarEvent } from 'angular-calendar';
import { addMinutes } from 'date-fns';
import { Subject } from 'rxjs';

@Component({
    selector: 'app-new-meeting-calendar',
    templateUrl: './new-meeting-calendar.component.html',
    styleUrls: ['./new-meeting-calendar.component.sass'],
    providers: [
        {
            provide: CalendarDateFormatter,
            useClass: CustomCalendarDateFormatter,
        },
    ],
    encapsulation: ViewEncapsulation.None,
})
export class NewMeetingCalendarComponent extends BaseComponent {
    private _duration: IDuration;

    @Input() set duration(value: IDuration) {
        this.refreshEvents();
        this._duration = value;
    }

    get duration() {
        return this._duration;
    }

    @Input() viewDate: Date;

    @Input() set unavailability(value: IUnavailability[]) {
        this.unavailablePeriods = value;
        this.refreshEvents();
    }

    @Output() meetingStartTimeChange: EventEmitter<Date> = new EventEmitter<Date>();

    events: CalendarEvent[] = [];

    past: CalendarEvent = {
        start: new Date(2000, 1),
        end: new Date(),
        title: '',
        cssClass: 'calendar-event',
        color: { primary: 'lightgray', secondary: 'lightgray' },
    };

    unavailablePeriods: IUnavailability[] = [];

    refresh: Subject<void> = new Subject<void>();

    constructor(private notificationsService: NotificationService) {
        super();
    }

    hourSegmentClicked(date: Date) {
        if (!this.duration.minutes || !this.checkSelectedDate(date)) {
            return;
        }

        const event: CalendarEvent = {
            start: date,
            end: addMinutes(date, this.duration.minutes),
            title: `${this.duration.time} ${this.duration.unitOfTime}`,
            cssClass: 'calendar-event',
            color: { primary: 'black', secondary: 'white' },
        };

        this.meetingStartTimeChange.emit(date);

        this.refreshEvents(event);
        this.refresh.next();
    }

    private refreshEvents(event?: CalendarEvent) {
        this.events = this.getUnavailableEvents().concat(this.past).concat(event ?? []);
    }

    private getUnavailableEvents(): CalendarEvent[] {
        return this.unavailablePeriods.map(value => ({
            start: new Date(value.start),
            end: new Date(value.end),
            title: '',
            cssClass: 'calendar-event',
            color: { primary: 'darkgray', secondary: 'darkgray' },
        }));
    }

    private checkSelectedDate(date: Date) {
        if (this.unavailablePeriods.some(u => this.isUnavailable(date, u))) {
            this.notificationsService.showInfoMessage('At least one selected team member is unavailable in this time period, try again');

            return false;
        }

        return true;
    }

    private isUnavailable(date: Date, unavailability: IUnavailability) {
        const start = new Date(unavailability.start);
        const end = new Date(unavailability.end);

        return this.containsDate(date, start, end) ||
            this.containsDate(addMinutes(date, this.duration.minutes!), start, end) ||
            (this.containsDate(start, date, addMinutes(date, this.duration.minutes!)) &&
                this.containsDate(end, date, addMinutes(date, this.duration.minutes!)));
    }

    private containsDate(date: Date, start: Date, end: Date) {
        return date > start && date < end;
    }
}
