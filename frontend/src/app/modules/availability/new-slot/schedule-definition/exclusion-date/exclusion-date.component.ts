import { Component, Input } from '@angular/core';
import { DateAdapter } from '@angular/material/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { BaseComponent } from '@core/base/base.component';
import { getDefaultSchedule } from '@core/helpers/default-schedule-helper';
import {
    convertExclusionDateToOffset,
    getUpdatedExclusionDatesDisplay,
    mergeExistingExclusionDates,
    sortDayTimeRanges,
} from '@core/helpers/exclusion-date-helper';
import { FindSameExclusionDateHelper } from '@core/helpers/find-same-exclusion-date-helper';
import { getTimeZoneHours } from '@core/helpers/time-helper';
import { TimeRangesMergeHelper } from '@core/helpers/time-ranges-merge-helper';
import { ITimeZone } from '@core/models/ITimeZone';
import { IExclusionDate } from '@core/models/schedule/exclusion-date/IExclusionDate';
import { ISchedule } from '@core/models/schedule/ISchedule';
import { ExclusionDatesPickerComponent } from '@modules/exclusion-dates/exclusion-dates-picker/exclusion-dates-picker.component';

@Component({
    selector: 'app-exclusion-date',
    templateUrl: './exclusion-date.component.html',
    styleUrls: ['./exclusion-date.component.sass'],
})
export class ExclusionDateComponent extends BaseComponent {
    public scheduleValue: ISchedule;

    exclusionDatesDisplay: IExclusionDate[] = [];

    @Input() disabled: boolean;

    constructor(private dialog: MatDialog, private dateAdapter: DateAdapter<Date>) {
        super();
    }

    @Input() set schedule(value: ISchedule | undefined) {
        this.scheduleValue = value ?? getDefaultSchedule(false);
        this.updateExclusionDatesDisplay();
    }

    updateExclusionDatesDisplay() {
        this.exclusionDatesDisplay = getUpdatedExclusionDatesDisplay(
            this.scheduleValue.exclusionDates,
            getTimeZoneHours(this.scheduleValue.timeZone.timeValue),
            this.dateAdapter,
        );
    }

    deleteExclusionDate(index: number) {
        const exclusionDateDisplayToDelete = this.exclusionDatesDisplay[index];
        const exclusionDateDisplaysToDeleteUtc = convertExclusionDateToOffset(
            exclusionDateDisplayToDelete,
            -getTimeZoneHours(this.scheduleValue.timeZone.timeValue),
            this.dateAdapter,
        );

        exclusionDateDisplaysToDeleteUtc.forEach((date) => {
            const sameDate = FindSameExclusionDateHelper(this.scheduleValue.exclusionDates, date);

            if (sameDate) {
                sameDate.dayTimeRanges = sameDate.dayTimeRanges.filter(
                    (range) =>
                        !date.dayTimeRanges.some(
                            (rangeToDelete) =>
                                rangeToDelete.start.hour === range.start.hour &&
                                rangeToDelete.start.minute === range.start.minute &&
                                rangeToDelete.end.hour === range.end.hour &&
                                rangeToDelete.end.minute === range.end.minute,
                        ),
                );

                sameDate.dayTimeRanges.forEach((range) => {
                    date.dayTimeRanges.forEach((rangeToDelete) => {
                        if (
                            rangeToDelete.start.hour === range.start.hour &&
                            rangeToDelete.start.minute === range.start.minute &&
                            rangeToDelete.end.hour <= range.end.hour &&
                            rangeToDelete.end.minute < range.end.minute
                        ) {
                            range.start = rangeToDelete.end;
                        } else if (
                            rangeToDelete.end.hour === range.end.hour &&
                            rangeToDelete.end.minute === range.end.minute &&
                            rangeToDelete.start.hour >= range.start.hour &&
                            rangeToDelete.start.minute > range.start.minute
                        ) {
                            range.end = rangeToDelete.start;
                        }
                    });
                });
            }
        });

        this.scheduleValue.exclusionDates = this.scheduleValue.exclusionDates.filter(
            (date) => date.dayTimeRanges.length,
        );
        this.updateExclusionDatesDisplay();
    }

    showExclusionDatesWindow() {
        const dialogConfig = new MatDialogConfig();

        dialogConfig.data = this.scheduleValue.timeZone;
        this.dialog
            .open<ExclusionDatesPickerComponent, ITimeZone, IExclusionDate[] | undefined>(ExclusionDatesPickerComponent, dialogConfig)
            .afterClosed()
            .subscribe((newExclusionDates) => {
                if (newExclusionDates) {
                    newExclusionDates.forEach((newExclusionDate) => {
                        sortDayTimeRanges(newExclusionDate.dayTimeRanges);
                        newExclusionDate.dayTimeRanges = TimeRangesMergeHelper(newExclusionDate.dayTimeRanges);

                        if (!mergeExistingExclusionDates(newExclusionDate, this.scheduleValue.exclusionDates)) {
                            this.scheduleValue.exclusionDates = [
                                ...this.scheduleValue.exclusionDates,
                                newExclusionDate,
                            ];
                        }
                    });
                    this.updateExclusionDatesDisplay();
                }
            });
    }
}
