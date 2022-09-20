import { DatePipe } from '@angular/common';
import { Component, Input } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { BaseComponent } from '@core/base/base.component';
import { CustomCalendarDateFormatter } from '@core/helpers/custom-calendar-date-formatter.provider';
import { parseTimeSpan } from '@core/helpers/schedule-items-helper';
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
        const scheduleItem = this.items.filter(item => item.weekDay.toString() === this.getWeekDay(new Date(date)))[0];
        const dialogRef = this.dialog.open(TimePickerDialogComponent, {
            data: scheduleItem,
        });

        dialogRef.afterClosed().subscribe(result => {
            this.items = this.items.map(item => {
                if (item.weekDay === result.weekDay) {
                    return result;
                }

                return item;
            });
        });
    }

    getWeekScheduleTime(date: string): string[] {
        const weekDay = this.getWeekDay(new Date(date));

        return this.items.filter(item => item.weekDay === weekDay && item.isEnabled)
            .map(item => `${this.formatTime(item.start)}-${this.formatTime(item.end)}`);
    }

    private getWeekDay(date: Date): string {
        return this.datePipe.transform(date, 'EEEE') ?? '';
    }

    private formatTime(date: string): string {
        return this.datePipe.transform(parseTimeSpan(date), 'HH:mm') ?? '';
    }
}
