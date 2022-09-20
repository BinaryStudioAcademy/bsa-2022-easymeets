import { DatePipe } from '@angular/common';
import { Component, Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { parseTimeSpan } from '@core/helpers/schedule-items-helper';
import { IScheduleItem } from '@core/models/schedule/IScheduleItem';

@Component({
    selector: 'app-time-picker-dialog',
    templateUrl: './time-picker-dialog.component.html',
    styleUrls: ['./time-picker-dialog.component.sass'],
})
export class TimePickerDialogComponent {
    start: string;

    end: string;

    isApplyActive: boolean;

    constructor(
        public dialogRef: MatDialogRef<TimePickerDialogComponent>,
        @Inject(MAT_DIALOG_DATA) public scheduleItem: IScheduleItem,
        private datePipe: DatePipe,
    ) {
        this.start = this.formatTime(scheduleItem.start);
        this.end = this.formatTime(scheduleItem.end);
    }

    onClickCancel() {
        this.dialogRef.close();
    }

    getNewScheduleItem() {
        const scheduleItem: IScheduleItem = {
            ...this.scheduleItem,
        };

        scheduleItem.start = this.start;
        scheduleItem.end = this.end;

        return scheduleItem;
    }

    compareTimes() {
        this.isApplyActive = parseTimeSpan(this.start).getTime() < parseTimeSpan(this.end).getTime();
    }

    private formatTime(date: string): string {
        return this.datePipe.transform(parseTimeSpan(date), 'HH:mm') ?? '';
    }
}
