import { Component, EventEmitter, Input, OnInit } from '@angular/core';
import { DateAdapter, MAT_DATE_LOCALE } from '@angular/material/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { BaseComponent } from '@core/base/base.component';
import { getDefaultSchedule } from '@core/helpers/default-schedule-helper';
import { getDisplayDays } from '@core/helpers/display-days-helper';
import {
    convertExclusionDateToOffset,
    getUpdatedExclusionDatesDisplay,
    mergeExistingExclusionDates,
    sortDayTimeRanges,
} from '@core/helpers/exclusion-date-helper';
import { FindSameExclusionDateHelper } from '@core/helpers/find-same-exclusion-date-helper';
import { changeOffsetSign } from '@core/helpers/time-helper';
import { TimeRangesMergeHelper } from '@core/helpers/time-ranges-merge-helper';
import { ITimeZone } from '@core/models/ITimeZone';
import { IExclusionDate } from '@core/models/schedule/exclusion-date/IExclusionDate';
import { ISchedule } from '@core/models/schedule/ISchedule';
import { UserService } from '@core/services/user.service';
import { CustomDateAdapter } from '@modules/exclusion-dates/custom-date-adapter';
import { ExclusionDatesPickerComponent } from '@modules/exclusion-dates/exclusion-dates-picker/exclusion-dates-picker.component';
import { TimeFormat } from '@shared/enums/timeFormat';

@Component({
    selector: 'app-schedule-definition',
    templateUrl: './schedule-definition.component.html',
    styleUrls: ['./schedule-definition.component.sass'],
    providers: [{ provide: DateAdapter, useClass: CustomDateAdapter, deps: [MAT_DATE_LOCALE] }],
})
export class ScheduleDefinitionComponent extends BaseComponent implements OnInit {
    @Input() changeEvent: EventEmitter<any> = new EventEmitter();

    @Input() set schedule(value: ISchedule | undefined) {
        this.scheduleValue = value ?? getDefaultSchedule(false);
        this.updateExclusionDatesDisplay();
    }

    public scheduleValue: ISchedule;

    @Input() disabled: boolean = false;

    displayDays: string[] = getDisplayDays();

    timeFormat?: TimeFormat;

    exclusionDatesDisplay: IExclusionDate[] = [];

    public checkZone(): boolean {
        return !this.scheduleValue.timeZone.nameValue;
    }

    constructor(private dialog: MatDialog, private userService: UserService, private dateAdapter: DateAdapter<Date>) {
        super();
    }

    ngOnInit(): void {
        this.userService.userChangedEvent$.pipe(this.untilThis).subscribe((user) => {
            this.timeFormat = user?.timeFormat;
        });
    }

    deleteExclusionDate(index: number) {
        const exclusionDateDisplayToDelete = this.exclusionDatesDisplay[index];
        const exclusionDateDisplaysToDeleteUtc = convertExclusionDateToOffset(
            exclusionDateDisplayToDelete,
            changeOffsetSign(this.scheduleValue.timeZone.timeValue),
            this.dateAdapter,
        );

        exclusionDateDisplaysToDeleteUtc.forEach(date => {
            const sameDate = FindSameExclusionDateHelper(this.scheduleValue.exclusionDates, date);

            if (sameDate) {
                const initialDayTimeRangesLength = sameDate.dayTimeRanges.length;

                sameDate.dayTimeRanges = sameDate.dayTimeRanges.filter(range => !date.dayTimeRanges.some(rangeToDelete =>
                    rangeToDelete.start === range.start && rangeToDelete.end === range.end));

                sameDate.dayTimeRanges.forEach(range => {
                    date.dayTimeRanges.forEach(rangeToDelete => {
                        if (rangeToDelete.start === range.start && rangeToDelete.end < range.end) {
                            range.start = rangeToDelete.end;
                        } else if (rangeToDelete.end === range.end && rangeToDelete.start > range.start) {
                            range.end = rangeToDelete.start;
                        }
                    });
                });

                if (initialDayTimeRangesLength && !sameDate.dayTimeRanges.length) {
                    this.scheduleValue.exclusionDates.filter(d => d !== sameDate);
                }
            }
        });

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

    updateExclusionDatesDisplay() {
        this.exclusionDatesDisplay = getUpdatedExclusionDatesDisplay(
            this.scheduleValue.exclusionDates,
            this.scheduleValue.timeZone.timeValue,
            this.dateAdapter,
        );
    }

    formatTime = (time: string) => time.substring(0, 5);
}
