import { Component, EventEmitter, Input, Output, ViewEncapsulation } from '@angular/core';
import { BaseComponent } from '@core/base/base.component';
import { CustomCalendarDateFormatter } from '@core/helpers/custom-calendar-date-formatter.provider';
import { IDuration } from '@core/models/IDuration';
import { IUnavailability } from '@core/models/IUnavailability';
import { isBetweenDates } from '@core/services/dates-interception-helper';
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
        this._duration = value;
        this.refreshEvents();
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

            return false;
        }

        if (this.unavailablePeriods.some(u => this.isUnavailable(date, addMinutes(date, this.duration.minutes!), u))) {
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
        let merged: IUnavailability[] = [];

        for (let i = 0; i < events.length; i++) {
            const currentIntercepting = this.getInterceptingEvents(events, events[i]);

            const mergedEvent = this.mergeEvents(currentIntercepting);

            const conflicts = this.getInterceptingEvents(merged, mergedEvent);

            merged = merged.filter(e => !conflicts.some(c => c.start === e.start && c.end === e.end));

            merged = [...merged, this.mergeEvents([...conflicts, mergedEvent])];
        }

        return merged;
    }

    public mergeEvents(events: IUnavailability[]): IUnavailability {
        return {
            start: this.getEarliestStart(events),
            end: this.getLatestEnd(events),
        };
    }

    public getInterceptingEvents(events: IUnavailability[], unavailability: IUnavailability) {
        return events.filter(e => this.isUnavailable(e.start, e.end, unavailability, false));
    }

    private getEarliestStart(events: IUnavailability[]) {
        return events.reduce((p, c) => (p.start < c.start ? p : c)).start;
    }

    private getLatestEnd(events: IUnavailability[]) {
        return events.reduce((p, c) => (p.end > c.end ? p : c)).end;
    }

    private isUnavailable(periodStart: Date, periodEnd: Date, unavailability: IUnavailability, restrictTouch: boolean = true) {
        return isBetweenDates(periodEnd, unavailability.start, unavailability.end, restrictTouch) ||
                isBetweenDates(unavailability.end, periodStart, periodEnd, restrictTouch);
    }
}
