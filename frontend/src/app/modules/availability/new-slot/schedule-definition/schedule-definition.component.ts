import { Component, EventEmitter, Input, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { BaseComponent } from '@core/base/base.component';
import { getDefaultSchedule } from '@core/helpers/default-schedule-helper';
import { getDisplayDays } from '@core/helpers/display-days-helper';
import { FindSameExclusionDateHelper } from '@core/helpers/find-same-exclusion-date-helper';
import { TimeRangesMergeHelper } from '@core/helpers/time-ranges-merge-helper';
import { IDayTimeRange } from '@core/models/schedule/exclusion-date/IDayTimeRange';
import { IExclusionDate } from '@core/models/schedule/exclusion-date/IExclusionDate';
import { ISchedule } from '@core/models/schedule/ISchedule';
import { UserService } from '@core/services/user.service';
import { ExclusionDatesPickerComponent } from '@modules/exclusion-dates/exclusion-dates-picker/exclusion-dates-picker.component';
import { TimeFormat } from '@shared/enums/timeFormat';

@Component({
    selector: 'app-schedule-definition',
    templateUrl: './schedule-definition.component.html',
    styleUrls: ['./schedule-definition.component.sass'],
})
export class ScheduleDefinitionComponent extends BaseComponent implements OnInit {
    @Input() changeEvent: EventEmitter<any> = new EventEmitter();

    @Input() set schedule(value: ISchedule | undefined) {
        this.scheduleValue = value ?? getDefaultSchedule(false);
    }

    public scheduleValue: ISchedule;

    @Input() disabled: boolean = false;

    displayDays: string[] = getDisplayDays();

    timeFormat?: TimeFormat;

    ngOnInit(): void {
        const user = this.userService.getLocalUser();

        this.timeFormat = user ? user.timeFormat : TimeFormat.TwentyFourHour;
    }

    public checkZone(): boolean {
        return !this.scheduleValue.timeZone.nameValue;
    }

    constructor(private dialog: MatDialog, private userService: UserService) {
        super();
    }

    deleteExclusionDate(index: number) {
        this.scheduleValue.exclusionDates = [
            ...this.scheduleValue.exclusionDates.slice(0, index),
            ...this.scheduleValue.exclusionDates.slice(index + 1),
        ];
    }

    showExclusionDatesWindow() {
        this.dialog
            .open<ExclusionDatesPickerComponent, IExclusionDate, IExclusionDate | undefined>(
                ExclusionDatesPickerComponent,
            )
            .afterClosed()
            .subscribe((newExclusionDate) => {
                if (newExclusionDate) {
                    this.sortDayTimeRanges(newExclusionDate.dayTimeRanges);
                    newExclusionDate.dayTimeRanges = TimeRangesMergeHelper(newExclusionDate.dayTimeRanges);

                    if (!this.mergeExistingExclusionDates(newExclusionDate)) {
                        this.scheduleValue.exclusionDates = [...this.scheduleValue.exclusionDates, newExclusionDate];
                    }
                }
            });
    }

    formatTime = (time: string) => time.substring(0, 5);

    private sortDayTimeRanges(ranges: IDayTimeRange[]) {
        return ranges.sort((firstRange, secondRange) => firstRange.start.localeCompare(secondRange.start));
    }

    private mergeExistingExclusionDates(newExclusionDate: IExclusionDate) {
        const sameDate = FindSameExclusionDateHelper(this.scheduleValue.exclusionDates, newExclusionDate);

        if (sameDate) {
            sameDate.dayTimeRanges = this.sortDayTimeRanges([
                ...sameDate.dayTimeRanges,
                ...newExclusionDate.dayTimeRanges,
            ]);
            sameDate.dayTimeRanges = TimeRangesMergeHelper(sameDate.dayTimeRanges);

            return true;
        }

        return false;
    }
}
