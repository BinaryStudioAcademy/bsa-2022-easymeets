import { Component, EventEmitter, Input, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { DatesEqualComparator } from '@core/helpers/dates-equal-comparator-helper';
import { getDisplayDays } from '@core/helpers/display-days-helper';
import { getPossibleTimeZones } from '@core/helpers/time-zone-helper';
import { ITimeZone } from '@core/models/ITimeZone';
import { IDayTimeRange } from '@core/models/schedule/exclusion-date/IDayTimeRange';
import { IExclusionDate } from '@core/models/schedule/exclusion-date/IExclusionDate';
import { ISchedule } from '@core/models/schedule/ISchedule';
import { ExclusionDatesPickerComponent } from '@modules/exclusion-dates/exclusion-dates-picker/exclusion-dates-picker.component';

@Component({
    selector: 'app-schedule-definition',
    templateUrl: './schedule-definition.component.html',
    styleUrls: ['./schedule-definition.component.sass'],
})
export class ScheduleDefinitionComponent implements OnInit {
    @Input() changeEvent: EventEmitter<any> = new EventEmitter();

    @Input() schedule: ISchedule;

    @Input() disabled: boolean = false;

    displayDays: string[] = getDisplayDays();

    readonly timeZones: ITimeZone[] = getPossibleTimeZones();

    selectedTimeZone: string;

    // eslint-disable-next-line no-empty-function
    constructor(private dialog: MatDialog) {}

    changeTimeZone() {
        this.schedule.timeZone = this.getSelectedTimeZoneValue();
    }

    getSelectedTimeZoneValue() {
        return this.timeZones.find((x) => x.displayValue === this.selectedTimeZone)?.value ?? 0;
    }

    getDisplayTimeZone(value: number) {
        return this.timeZones.find((x) => x.value === value)?.displayValue ?? '';
    }

    ngOnInit(): void {
        this.selectedTimeZone = this.getDisplayTimeZone(this.schedule.timeZone);
    }

    deleteExclusionDate(index: number) {
        this.schedule.exclusionDates.splice(index, 1);
    }

    showExclusionDatesWindow() {
        this.dialog
            .open<ExclusionDatesPickerComponent, any, IExclusionDate | undefined>(ExclusionDatesPickerComponent)
            .afterClosed()
            .subscribe((newExclusionDate) => {
                if (newExclusionDate) {
                    this.sortDayTimeRanges(newExclusionDate.dayTimeRanges);
                    newExclusionDate.dayTimeRanges = this.mergeDayTimeRanges(newExclusionDate.dayTimeRanges);

                    if (!this.mergeExistingExclusionDates(newExclusionDate)) {
                        this.schedule.exclusionDates.push(newExclusionDate);
                    }
                }
            });
    }

    formatTime = (time: string) => time.substring(0, 5);

    private sortDayTimeRanges(ranges: IDayTimeRange[]) {
        ranges.sort((firstRange, secondRange) => firstRange.start.localeCompare(secondRange.start));
    }

    private mergeDayTimeRanges(ranges: IDayTimeRange[]) {
        const mergedExclusionDates: IDayTimeRange[] = [];
        let currentDate = ranges.shift();

        while (currentDate) {
            let allFurtherDatesMerged = false;

            let dateToMerge = ranges.shift();

            while (!allFurtherDatesMerged && dateToMerge) {
                if (dateToMerge.start <= currentDate.end && dateToMerge.end > currentDate.end) {
                    currentDate.end = dateToMerge.end;
                    dateToMerge = ranges.shift();
                } else if (dateToMerge.start > currentDate.end) {
                    allFurtherDatesMerged = true;
                } else {
                    dateToMerge = ranges.shift();
                }
            }
            mergedExclusionDates.push(currentDate);
            currentDate = ranges.shift();
        }

        return mergedExclusionDates;
    }

    private mergeExistingExclusionDates(newExclusionDate: IExclusionDate) {
        const sameDate = this.schedule.exclusionDates.find((date) =>
            DatesEqualComparator(new Date(date.selectedDate), newExclusionDate.selectedDate));

        if (sameDate) {
            sameDate.dayTimeRanges = [...sameDate.dayTimeRanges, ...newExclusionDate.dayTimeRanges];
            this.sortDayTimeRanges(sameDate.dayTimeRanges);
            sameDate.dayTimeRanges = this.mergeDayTimeRanges(sameDate.dayTimeRanges);

            return true;
        }

        return false;
    }
}
