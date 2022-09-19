import { Component, Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
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
    ) {
        this.start = scheduleItem.start.substring(0, 5);
        this.end = scheduleItem.end.substring(0, 5);
    }

    onClickCancel() {
        this.dialogRef.close();
    }

    onClickApply() {
        this.scheduleItem.start = this.start;
        this.scheduleItem.end = this.end;
    }

    compareTimes() {
        this.isApplyActive = this.timeToDate(this.start) < this.timeToDate(this.end);
    }

    timeToDate(time: string): Date {
        const chunks = time.split(':');
        const date = new Date();

        date.setHours(Number(chunks[0]));
        date.setMinutes(Number(chunks[1]));

        return date;
    }
}
