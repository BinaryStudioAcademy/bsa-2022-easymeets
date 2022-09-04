import { Component, EventEmitter, Input, Output, ViewEncapsulation } from '@angular/core';
import { CustomCalendarDateFormatter } from '@core/helpers/custom-calendar-date-formatter.provider';
import { IDuration } from '@core/models/IDuration';
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
export class NewMeetingCalendarComponent {
    private _duration: IDuration;

    @Input() set duration(value: IDuration) {
        this.events = [];
        this._duration = value;
    }

    get duration() {
        return this._duration;
    }

    @Input() viewDate: Date;

    @Output() meetingStartTimeChange: EventEmitter<Date> = new EventEmitter<Date>();

    events: CalendarEvent[] = [];

    refresh: Subject<void> = new Subject<void>();

    hourSegmentClicked(date: Date) {
        if (this.duration.minutes == null) {
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

        this.events = [event];
        this.refresh.next();
    }
}
