import { DatePipe } from '@angular/common';
import { Component, Input } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { BaseComponent } from '@core/base/base.component';
import { CustomCalendarDateFormatter } from '@core/helpers/custom-calendar-date-formatter.provider';
import { getDefaultSchedule } from '@core/helpers/default-schedule-helper';
import { FindSameExclusionDateHelper } from '@core/helpers/find-same-exclusion-date-helper';
import { TimeRangesMergeHelper } from '@core/helpers/time-ranges-merge-helper';
import { IDayTimeRange } from '@core/models/schedule/exclusion-date/IDayTimeRange';
import { IExclusionDate } from '@core/models/schedule/exclusion-date/IExclusionDate';
import { ISchedule } from '@core/models/schedule/ISchedule';
import { IScheduleItem } from '@core/models/schedule/IScheduleItem';
import {
    ExclusionDatesPickerComponent,
} from '@modules/exclusion-dates/exclusion-dates-picker/exclusion-dates-picker.component';
import {
    CalendarDateFormatter,
} from 'angular-calendar';

@Component({
    selector: 'app-schedule-month',
    templateUrl: './schedule-month.component.html',
    styleUrls: ['./schedule-month.component.sass'],
    providers: [
        {
            provide: CalendarDateFormatter,
            useClass: CustomCalendarDateFormatter,
        },
    ],
})

export class ScheduleMonthComponent extends BaseComponent {
    @Input() items: IScheduleItem[];

    @Input() set schedule(value: ISchedule | undefined) {
        this.scheduleValue = value ?? getDefaultSchedule(false);
    }

    scheduleValue: ISchedule;

    viewDate: Date = new Date();

    constructor(private dialog: MatDialog, private datePipe: DatePipe) {
        super();
    }

    getWeekScheduleTime(date: string): string[] {
        const weekDay = this.getWeekDay(new Date(date));
        const scheduleItems = this.items.filter(item => item.weekDay === weekDay && item.isEnabled)
            .map(item => `${item.start.substring(0, 5)}-${item.end.substring(0, 5)}`);

        return scheduleItems;
    }

    getScheduleTime(date: string): string[] {
        const scheduleItems = this.scheduleValue.exclusionDates
            .filter(item => this.compareDate(item.selectedDate, new Date(date)))
            .flatMap(a => a.dayTimeRanges)
            .map(item => `${item.start.substring(0, 5)}-${item.end.substring(0, 5)}`);

        return scheduleItems;
    }

    resetToDefault(date: string) {
        this.scheduleValue.exclusionDates = this.scheduleValue.exclusionDates.filter(
            (value) => !this.compareDate(value.selectedDate, new Date(date)),
        );
    }

    showExclusionDatesWindow() {
        this.dialog
            .open<ExclusionDatesPickerComponent, IExclusionDate, IExclusionDate | undefined>(ExclusionDatesPickerComponent)
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

    private getWeekDay(date: Date): string {
        return this.datePipe.transform(date, 'EEEE') ?? '';
    }

    private sortDayTimeRanges(ranges: IDayTimeRange[]) {
        return ranges.sort((firstRange, secondRange) => firstRange.start.localeCompare(secondRange.start));
    }

    private compareDate(date1: Date, date2: Date): boolean {
        date1 = new Date(date1);
        date2 = new Date(date2);

        return date1.getFullYear() === date2.getFullYear() && date1.getMonth() === date2.getMonth() && date1.getDate() === date2.getDate();
    }
}
