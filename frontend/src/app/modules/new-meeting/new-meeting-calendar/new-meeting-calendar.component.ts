import { Component, EventEmitter, Input, OnChanges, OnInit, Output, ViewEncapsulation } from '@angular/core';
import { BaseComponent } from '@core/base/base.component';
import { CustomCalendarDateFormatter } from '@core/helpers/custom-calendar-date-formatter.provider';
import { getCurrentDate } from '@core/helpers/time-zone-helper';
import {
    applyDefaultTimeZone,
    isUnavailable,
    mergeUnavailabilities,
    removeFinished,
    shortenStarted,
} from '@core/helpers/unavailability-helper';
import { IDuration } from '@core/models/IDuration';
import { IUnavailability } from '@core/models/IUnavailability';
import { NotificationService } from '@core/services/notification.service';
import { TimeZoneService } from '@core/services/time-zone.service';
import { CalendarDateFormatter, CalendarEvent } from 'angular-calendar';
import { addMinutes } from 'date-fns';
import { interval, Subject } from 'rxjs';

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
export class NewMeetingCalendarComponent extends BaseComponent implements OnChanges, OnInit {
    private _duration: IDuration;

    private calendarRefreshFrequency = 30000;

    @Input() set duration(value: IDuration) {
        this._duration = value;
        this.refreshEvents();
    }

    get duration() {
        return this._duration;
    }

    @Input() viewDate: Date;

    @Input() set unavailability(value: IUnavailability[]) {
        this.unavailablePeriodsRaw = value;
        this.unavailablePeriods = this.filterEvents(value);
        this.refreshEvents();
    }

    @Input() event: CalendarEvent;

    @Output() meetingStartTimeChange: EventEmitter<Date> = new EventEmitter<Date>();

    events: CalendarEvent[] = [];

    past: CalendarEvent = {
        start: new Date(2000, 1),
        end: getCurrentDate(),
        title: '',
        cssClass: 'calendar-event',
        color: { primary: 'lightgray', secondary: 'lightgray' },
    };

    unavailablePeriodsRaw: IUnavailability[] = [];

    unavailablePeriods: IUnavailability[] = [];

    refresh: Subject<void> = new Subject<void>();

    constructor(private notificationsService: NotificationService, private timeZoneService: TimeZoneService) {
        super();
    }

    ngOnChanges(): void {
        this.refreshEvents(this.event);
    }

    ngOnInit() {
        this.timeZoneService.timeZoneChangedEvent$.pipe(this.untilThis).subscribe({
            next: () => this.updateCalendar(),
        });

        interval(this.calendarRefreshFrequency)
            .pipe(this.untilThis)
            .subscribe(() => {
                this.updateCalendar();
            });
    }

    updateCalendar() {
        this.unavailablePeriods = this.filterEvents(this.unavailablePeriodsRaw);
        this.past.end = getCurrentDate();

        this.refreshEvents();
        this.refresh.next();
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
        this.events = this.getUnavailableEvents()
            .concat(this.past)
            .concat(event ?? []);
    }

    private getUnavailableEvents(): CalendarEvent[] {
        return this.unavailablePeriods.map((value) => ({
            start: new Date(value.start),
            end: new Date(value.end),
            title: '',
            cssClass: 'calendar-event',
            color: { primary: 'darkgray', secondary: 'darkgray' },
        }));
    }

    private checkSelectedDate(date: Date) {
        if (date < getCurrentDate()) {
            this.notificationsService.showInfoMessage('You cannot select time period that starts in the past');

            return false;
        }

        if (this.unavailablePeriods.some((u) => isUnavailable(date, addMinutes(date, this.duration.minutes!), u))) {
            this.notificationsService.showInfoMessage(
                'At least one selected team member is unavailable in this time period, try again',
            );

            return false;
        }

        return true;
    }

    private filterEvents(events: IUnavailability[]) {
        const converted = applyDefaultTimeZone(events);

        const unfinished = removeFinished(converted);

        const trimmed = shortenStarted(unfinished);

        return mergeUnavailabilities(trimmed);
    }
}
