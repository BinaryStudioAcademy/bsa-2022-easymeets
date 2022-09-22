import { Component, Input } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { BaseComponent } from '@core/base/base.component';
import { getDefaultSchedule } from '@core/helpers/default-schedule-helper';
import { sortExclusionTimeRanges } from '@core/helpers/exclusion-date-helper';
import { ExclusionTimeRangesMergeHelper } from '@core/helpers/exclusion-time-ranges-merge-helper';
import { ITimeZone } from '@core/models/ITimeZone';
import { IExclusionTimeRange } from '@core/models/schedule/exclusion-date/IExclusionTimeRange';
import { IExclusionTimeRangesDisplay } from '@core/models/schedule/exclusion-date/IExclusionTimeRangesDisplay';
import { ISchedule } from '@core/models/schedule/ISchedule';
import { ExclusionDatesPickerComponent } from '@modules/exclusion-dates/exclusion-dates-picker/exclusion-dates-picker.component';
import * as moment from 'moment-timezone';

@Component({
    selector: 'app-exclusion-date',
    templateUrl: './exclusion-date.component.html',
    styleUrls: ['./exclusion-date.component.sass'],
})
export class ExclusionDateComponent extends BaseComponent {
    public scheduleValue: ISchedule;

    exclusionDatesDisplay: IExclusionTimeRangesDisplay[] = [];

    @Input() disabled: boolean;

    constructor(private dialog: MatDialog) {
        super();
    }

    @Input() set schedule(value: ISchedule | undefined) {
        this.scheduleValue = value ?? getDefaultSchedule(false);
        this.updateExclusionTimeRangesDisplay();
    }

    deleteExclusionTimeRange(exclusionTimeRangeToDelete: IExclusionTimeRangesDisplay) {
        sortExclusionTimeRanges(exclusionTimeRangeToDelete.connectedExclusionTimeRanges);
        const startRangeToDelete = exclusionTimeRangeToDelete.connectedExclusionTimeRanges[0];

        if (
            moment.utc(startRangeToDelete.start).tz(this.scheduleValue.timeZone.nameValue).startOf('day').toDate() <
            moment.utc(exclusionTimeRangeToDelete.date).tz(this.scheduleValue.timeZone.nameValue).toDate()
        ) {
            exclusionTimeRangeToDelete.connectedExclusionTimeRanges.filter((range) => range !== startRangeToDelete);
            const exclusionDateToEdit = this.scheduleValue.exclusionTimeRanges.find(
                (range) =>
                    moment.utc(startRangeToDelete.start).toDate().getTime() ===
                    moment.utc(range.start).toDate().getTime(),
            );

            if (exclusionDateToEdit) {
                exclusionDateToEdit.end = moment.utc(exclusionDateToEdit.start)
                    .tz(this.scheduleValue.timeZone.nameValue)
                    .endOf('day')
                    .utc()
                    .format();
            }
        }
        const endRangeToDelete =
            exclusionTimeRangeToDelete.connectedExclusionTimeRanges[
                exclusionTimeRangeToDelete.connectedExclusionTimeRanges.length - 1
            ];

        if (
            moment.utc(endRangeToDelete.end).tz(this.scheduleValue.timeZone.nameValue).startOf('day').toDate() >
            moment.utc(exclusionTimeRangeToDelete.date).tz(this.scheduleValue.timeZone.nameValue).toDate()
        ) {
            exclusionTimeRangeToDelete.connectedExclusionTimeRanges.filter((range) => range !== endRangeToDelete);
            const exclusionDateToEdit = this.scheduleValue.exclusionTimeRanges.find(
                (range) =>
                    moment.utc(endRangeToDelete.end)
                        .tz(this.scheduleValue.timeZone.nameValue)
                        .utc()
                        .toDate()
                        .getTime() ===
                    moment.utc(range.end)
                        .tz(this.scheduleValue.timeZone.nameValue)
                        .toDate()
                        .getTime(),
            );

            if (exclusionDateToEdit) {
                exclusionDateToEdit.start = moment.utc(exclusionDateToEdit.end)
                    .tz(this.scheduleValue.timeZone.nameValue)
                    .startOf('day')
                    .utc()
                    .format();
            }
        }
        this.scheduleValue.exclusionTimeRanges = this.scheduleValue.exclusionTimeRanges.filter(
            (range) =>
                !exclusionTimeRangeToDelete.connectedExclusionTimeRanges.some(
                    (connectedRange) =>
                        moment.utc(range.start).toDate().getTime() ===
                            moment.utc(connectedRange.start).toDate().getTime() &&
                        moment.utc(range.end).toDate().getTime() === moment.utc(connectedRange.end).toDate().getTime(),
                ),
        );
        this.updateExclusionTimeRangesDisplay();
    }

    updateExclusionTimeRangesDisplay() {
        const convertedExclusionTimeRanges: IExclusionTimeRange[] = this.scheduleValue.exclusionTimeRanges.map(
            (range) => ({
                start: moment.utc(range.start).tz(this.scheduleValue.timeZone.nameValue).format(),
                end: moment.utc(range.end).tz(this.scheduleValue.timeZone.nameValue).format(),
            }),
        );

        this.exclusionDatesDisplay = convertedExclusionTimeRanges
            .map((range) => [range.start, range.end])
            .flat()
            .map((date) => moment(date).tz(this.scheduleValue.timeZone.nameValue).startOf('day').format())
            .filter((value, index, self) => self.indexOf(value) === index)
            .map((date) => ({
                date,
                connectedExclusionTimeRanges: convertedExclusionTimeRanges.filter((convertedRange) => {
                    const startMomentDate = moment.utc(convertedRange.start)
                        .tz(this.scheduleValue.timeZone.nameValue)
                        .startOf('day')
                        .format();
                    const endMomentDate = moment.utc(convertedRange.end)
                        .tz(this.scheduleValue.timeZone.nameValue)
                        .startOf('day')
                        .format();

                    return (
                        startMomentDate === date ||
                        (endMomentDate === date &&
                            moment.utc(convertedRange.end).tz(this.scheduleValue.timeZone.nameValue).toDate().getTime() -
                                moment.utc(date).tz(this.scheduleValue.timeZone.nameValue).toDate().getTime() !==
                                0)
                    );
                }),
            }))
            .filter((display) => display.connectedExclusionTimeRanges.length);
    }

    showExclusionTimeRangesWindow() {
        const dialogConfig = new MatDialogConfig();

        dialogConfig.data = this.scheduleValue.timeZone;
        this.dialog
            .open<ExclusionDatesPickerComponent, ITimeZone, IExclusionTimeRange[] | undefined>(
                ExclusionDatesPickerComponent,
                dialogConfig,
            )
            .afterClosed()
            .subscribe((newExclusionTimeRanges) => {
                if (newExclusionTimeRanges) {
                    this.scheduleValue.exclusionTimeRanges = ExclusionTimeRangesMergeHelper([
                        ...this.scheduleValue.exclusionTimeRanges,
                        ...newExclusionTimeRanges,
                    ]);
                    this.updateExclusionTimeRangesDisplay();
                }
            });
    }
}
