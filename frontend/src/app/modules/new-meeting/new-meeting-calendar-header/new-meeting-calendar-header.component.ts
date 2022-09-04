import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
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

    ngOnInit(): void {
        this.changeWeekRange();
    }

    previousWeek() {
        this.changeDateToWeek(-1);
    }

    nextWeek() {
        this.changeDateToWeek(1);
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
