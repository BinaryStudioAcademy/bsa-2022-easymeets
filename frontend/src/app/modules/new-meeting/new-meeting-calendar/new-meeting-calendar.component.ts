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
        this.unavailablePeriods = this.filterEvents(value);
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
        if (date < new Date()) {
            this.notificationsService.showInfoMessage('You cannot select time period that starts in the past');

            return;
        }

        if (this.unavailablePeriods.some(u => this.isUnavailable(date, u))) {
            this.notificationsService.showInfoMessage('At least one selected team member is unavailable in this time period, try again');

            return false;
        }

        return true;
    }

    private filterEvents(events: IUnavailability[]) {
        const converted = this.convertDates(events);

        const unfinished = this.removeFinished(converted);

        const trimmed = this.shortenStarted(unfinished);

        return this.mergeUnavailabilities(trimmed);
    }

    private convertDates(events: IUnavailability[]): IUnavailability[] {
        return events.map(e => ({ start: new Date(e.start), end: new Date(e.end) }));
    }

    private removeFinished(events: IUnavailability[]) {
        return events.filter(e => e.end > new Date());
    }

    private shortenStarted(events: IUnavailability[]) {
        return events.map(e => {
            if (e.start < new Date()) {
                return { ...e, start: addMinutes(new Date(), 1) };
            }

            return e;
        });
    }

    private mergeUnavailabilities(events: IUnavailability[]) {
        const merged: IUnavailability[] = [];

        events.map((value, index, array) => {
            const currentIntercepting = array.filter(e => this.isUnavailable(e.start, value, true) ||
                this.isUnavailable(new Date(e.end), value, true));

            const mergedEvent: IUnavailability = {
                start: currentIntercepting.reduce((p, c) => (p.start < c.start ? p : c)).start,
                end: currentIntercepting.reduce((p, c) => (p.end > c.end ? p : c)).end,
            };

            if (!merged.find(e => e.start === mergedEvent.start && e.end === mergedEvent.end)) {
                merged.push(mergedEvent);
            }

            return value;
        });

        return merged;
    }

    private isUnavailable(date: Date, unavailability: IUnavailability, unstrict?: boolean) {
        const dateEnd = addMinutes(date, this.duration.minutes!);

        return this.containsDate(date, unavailability.start, unavailability.end, unstrict) ||
            this.containsDate(dateEnd, unavailability.start, unavailability.end, unstrict) ||
            (this.containsDate(unavailability.start, date, dateEnd, true) &&
                this.containsDate(unavailability.end, date, dateEnd, true));
    }

    private containsDate(date: Date, start: Date, end: Date, unstrict?: boolean) {
        if (unstrict === true) {
            return date >= start && date <= end;
        }

        return date > start && date < end;
    }
}
