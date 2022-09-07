import { Component, EventEmitter, Input } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { DatesEqualComparator } from '@core/helpers/dates-equal-comparator-helper';
import { getDefaultSchedule } from '@core/helpers/default-schedule-helper';
import { getDisplayDays } from '@core/helpers/display-days-helper';
import { TimeRangesMergeHelper } from '@core/helpers/time-ranges-merge-helper';
import { IDayTimeRange } from '@core/models/schedule/exclusion-date/IDayTimeRange';
import { IExclusionDate } from '@core/models/schedule/exclusion-date/IExclusionDate';
import { ISchedule } from '@core/models/schedule/ISchedule';
import { ExclusionDatesPickerComponent } from '@modules/exclusion-dates/exclusion-dates-picker/exclusion-dates-picker.component';

@Component({
    selector: 'app-schedule-definition',
    templateUrl: './schedule-definition.component.html',
    styleUrls: ['./schedule-definition.component.sass'],
})
export class ScheduleDefinitionComponent {
    @Input() changeEvent: EventEmitter<any> = new EventEmitter();

    @Input() set schedule(value: ISchedule | undefined) {
        this.scheduleValue = value ?? getDefaultSchedule(false);
    }

    public scheduleValue: ISchedule;

    @Input() disabled: boolean = false;

    displayDays: string[] = getDisplayDays();

    public checkZone(): boolean {
        return !this.scheduleValue.timeZone.nameValue;
    }

    // eslint-disable-next-line no-empty-function
    constructor(private dialog: MatDialog) {}

    deleteExclusionDate(index: number) {
        this.scheduleValue.exclusionDates.splice(index, 1);
    }

    showExclusionDatesWindow() {
        this.dialog
            .open<ExclusionDatesPickerComponent, any, IExclusionDate | undefined>(ExclusionDatesPickerComponent)
            .afterClosed()
            .subscribe((newExclusionDate) => {
                if (newExclusionDate) {
                    this.sortDayTimeRanges(newExclusionDate.dayTimeRanges);
                    newExclusionDate.dayTimeRanges = TimeRangesMergeHelper(newExclusionDate.dayTimeRanges);

                    if (!this.mergeExistingExclusionDates(newExclusionDate)) {
                        this.scheduleValue.exclusionDates.push(newExclusionDate);
                    }
                }
            });
    }

    formatTime = (time: string) => time.substring(0, 5);

    private sortDayTimeRanges(ranges: IDayTimeRange[]) {
        ranges.sort((firstRange, secondRange) => firstRange.start.localeCompare(secondRange.start));
    }

    private mergeExistingExclusionDates(newExclusionDate: IExclusionDate) {
        const sameDate = this.scheduleValue.exclusionDates.find((date) =>
            DatesEqualComparator(new Date(date.selectedDate), newExclusionDate.selectedDate));

        if (sameDate) {
            sameDate.dayTimeRanges = [...sameDate.dayTimeRanges, ...newExclusionDate.dayTimeRanges];
            this.sortDayTimeRanges(sameDate.dayTimeRanges);
            sameDate.dayTimeRanges = TimeRangesMergeHelper(sameDate.dayTimeRanges);

            return true;
        }

        return false;
    }
}
