import { Component, Input } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { BaseComponent } from '@core/base/base.component';
import { getDefaultSchedule } from '@core/helpers/default-schedule-helper';
import { findExclusionTimeRange, sortExclusionTimeRanges } from '@core/helpers/exclusion-date-helper';
import { ExclusionTimeRangesMergeHelper } from '@core/helpers/exclusion-time-ranges-merge-helper';
import {
    getDateStringWithTimeZone,
    getDayStartStringWithTimeZone,
    getMillisecondsFromDateString,
} from '@core/helpers/time-helper';
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

    deleteExclusionTimeRange(exclusionTimeRangesDisplayToDelete: IExclusionTimeRangesDisplay) {
        sortExclusionTimeRanges(exclusionTimeRangesDisplayToDelete.connectedExclusionTimeRanges);
        const startRangeToUpdate = exclusionTimeRangesDisplayToDelete.connectedExclusionTimeRanges[0];

        this.updateRangeStart(
            startRangeToUpdate,
            this.scheduleValue.exclusionTimeRanges,
            exclusionTimeRangesDisplayToDelete,
        );
        const endRangeToUpdate =
            exclusionTimeRangesDisplayToDelete.connectedExclusionTimeRanges[
                exclusionTimeRangesDisplayToDelete.connectedExclusionTimeRanges.length - 1
            ];

        this.updateRangeEnd(
            endRangeToUpdate,
            this.scheduleValue.exclusionTimeRanges,
            exclusionTimeRangesDisplayToDelete,
        );
        this.scheduleValue.exclusionTimeRanges = this.scheduleValue.exclusionTimeRanges.filter(
            (range) =>
                !exclusionTimeRangesDisplayToDelete.connectedExclusionTimeRanges.some(
                    (connectedRange) =>
                        getMillisecondsFromDateString(range.start) ===
                            getMillisecondsFromDateString(connectedRange.start) &&
                        getMillisecondsFromDateString(range.end) === getMillisecondsFromDateString(connectedRange.end),
                ),
        );
        this.updateExclusionTimeRangesDisplay();
    }

    updateExclusionTimeRangesDisplay() {
        const convertedExclusionTimeRanges: IExclusionTimeRange[] = this.scheduleValue.exclusionTimeRanges.map(
            (range) => ({
                start: getDateStringWithTimeZone(range.start, this.scheduleValue.timeZone.nameValue),
                end: getDateStringWithTimeZone(range.end, this.scheduleValue.timeZone.nameValue),
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
                    const startMomentDate = getDayStartStringWithTimeZone(
                        convertedRange.start,
                        this.scheduleValue.timeZone.nameValue,
                    );
                    const endMomentDate = getDayStartStringWithTimeZone(
                        convertedRange.end,
                        this.scheduleValue.timeZone.nameValue,
                    );

                    return (
                        startMomentDate === date ||
                        (endMomentDate === date &&
                            moment
                                .utc(convertedRange.end)
                                .tz(this.scheduleValue.timeZone.nameValue)
                                .toDate()
                                .getTime() -
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
            .open<ExclusionDatesPickerComponent, ITimeZone, IExclusionTimeRange[] | undefined>(ExclusionDatesPickerComponent, dialogConfig)
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

    private updateRangeStart(
        startRangeToUpdate: IExclusionTimeRange,
        exclusionTimeRanges: IExclusionTimeRange[],
        exclusionTimeRangesDisplayToDelete: IExclusionTimeRangesDisplay,
    ) {
        if (
            moment.utc(startRangeToUpdate.start).tz(this.scheduleValue.timeZone.nameValue).startOf('day').toDate() <
            moment.utc(exclusionTimeRangesDisplayToDelete.date).tz(this.scheduleValue.timeZone.nameValue).toDate()
        ) {
            const exclusionTimeRangeToUpdate = findExclusionTimeRange(startRangeToUpdate, exclusionTimeRanges);

            if (exclusionTimeRangeToUpdate) {
                exclusionTimeRangeToUpdate.end = moment
                    .utc(exclusionTimeRangeToUpdate.start)
                    .tz(this.scheduleValue.timeZone.nameValue)
                    .endOf('day')
                    .utc()
                    .format();
            }
        }
    }

    private updateRangeEnd(
        endRangeToUpdate: IExclusionTimeRange,
        exclusionTimeRanges: IExclusionTimeRange[],
        exclusionTimeRangesDisplayToDelete: IExclusionTimeRangesDisplay,
    ) {
        if (
            moment.utc(endRangeToUpdate.end).tz(this.scheduleValue.timeZone.nameValue).startOf('day').toDate() >
            moment.utc(exclusionTimeRangesDisplayToDelete.date).tz(this.scheduleValue.timeZone.nameValue).toDate()
        ) {
            const exclusionDateToEdit = findExclusionTimeRange(endRangeToUpdate, exclusionTimeRanges);

            if (exclusionDateToEdit) {
                exclusionDateToEdit.start = moment
                    .utc(exclusionDateToEdit.end)
                    .tz(this.scheduleValue.timeZone.nameValue)
                    .startOf('day')
                    .utc()
                    .format();
            }
        }
    }
}
