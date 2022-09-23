import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { getDefaultTimeZone, setTimeZone } from '@core/helpers/time-zone-helper';
import { ITimeZone } from '@core/models/ITimeZone';
import { TimeZoneService } from '@core/services/time-zone.service';
import { addWeeks, endOfWeek, format, startOfWeek } from 'date-fns';

@Component({
    selector: 'app-new-meeting-calendar-header',
    templateUrl: './new-meeting-calendar-header.component.html',
    styleUrls: ['./new-meeting-calendar-header.component.sass'],
})
export class NewMeetingCalendarHeaderComponent implements OnInit {
    @Input() date: Date;

    @Output() dateChange: EventEmitter<Date> = new EventEmitter<Date>();

    weekRange: string = '';

    timeZone: ITimeZone;

    // eslint-disable-next-line no-empty-function
    constructor(private timeZoneService: TimeZoneService) {}

    ngOnInit(): void {
        this.changeWeekRange();
        this.timeZone = getDefaultTimeZone();
    }

    previousWeek() {
        this.changeDateToWeek(-1);
    }

    nextWeek() {
        this.changeDateToWeek(1);
    }

    checkZone(): boolean {
        return !this.timeZone;
    }

    saveTimeZone() {
        setTimeZone(this.timeZone);
        this.timeZoneService.timeZoneChanged(this.timeZone);
    }

    private changeDateToWeek(number: number) {
        this.date = addWeeks(this.date, number);

        this.changeWeekRange();

        this.dateChange.emit(this.date);
    }

    private changeWeekRange() {
        this.weekRange = `${format(startOfWeek(this.date), 'd MMM')} - ${format(endOfWeek(this.date), 'd MMM, yyyy')}`;
    }
}
