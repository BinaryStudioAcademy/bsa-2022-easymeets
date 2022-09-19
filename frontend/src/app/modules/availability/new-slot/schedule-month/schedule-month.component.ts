import { DatePipe } from '@angular/common';
import { Component, Input } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { BaseComponent } from '@core/base/base.component';
import { CustomCalendarDateFormatter } from '@core/helpers/custom-calendar-date-formatter.provider';
import { IScheduleItem } from '@core/models/schedule/IScheduleItem';
import { TimePickerDialogComponent } from '@shared/components/time-picker-dialog/time-picker-dialog.component';
import { CalendarDateFormatter } from 'angular-calendar';

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

export class ScheduleMonthComponent extends BaseComponent {
    @Input() items: IScheduleItem[];

    viewDate: Date = new Date();

    constructor(private dialog: MatDialog, private datePipe: DatePipe) {
        super();
    }

    openDialog(date: string): void {
        this.dialog.open(TimePickerDialogComponent, {
            data: this.items.filter(item => item.weekDay.toString() === this.getWeekDay(new Date(date)))[0],
        });
    }

    getWeekScheduleTime(date: string): string[] {
        const weekDay = this.getWeekDay(new Date(date));

        return this.items.filter(item => item.weekDay === weekDay && item.isEnabled)
            .map(item => `${item.start.substring(0, 5)}-${item.end.substring(0, 5)}`);
    }

    private getWeekDay(date: Date): string {
        return this.datePipe.transform(date, 'EEEE') ?? '';
    }
}
