import { Component, Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { compareTimeSpan, stringToTimeSpan, timeSpanToString } from '@core/helpers/schedule-items-helper';
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
        this.start = timeSpanToString(scheduleItem.start);
        this.end = timeSpanToString(scheduleItem.end);
    }

    onClickCancel() {
        this.dialogRef.close();
    }

    getNewScheduleItem() {
        const scheduleItem: IScheduleItem = {
            ...this.scheduleItem,
        };

        scheduleItem.start = stringToTimeSpan(this.start);
        scheduleItem.end = stringToTimeSpan(this.end);

        return scheduleItem;
    }

    compareTimes() {
        this.isApplyActive = compareTimeSpan(stringToTimeSpan(this.start), stringToTimeSpan(this.end));
    }
}
