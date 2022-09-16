import { Component, Input } from '@angular/core';
import { DateAdapter } from '@angular/material/core';
import { BaseComponent } from '@core/base/base.component';
import { getDefaultSchedule } from '@core/helpers/default-schedule-helper';
import { convertExclusionDateToOffset, getUpdatedExclusionDatesDisplay } from '@core/helpers/exclusion-date-helper';
import { FindSameExclusionDateHelper } from '@core/helpers/find-same-exclusion-date-helper';
import { changeOffsetSign } from '@core/helpers/time-helper';
import { IExclusionDate } from '@core/models/schedule/exclusion-date/IExclusionDate';
import { ISchedule } from '@core/models/schedule/ISchedule';

@Component({
    selector: 'app-exclusion-date',
    templateUrl: './exclusion-date.component.html',
    styleUrls: ['./exclusion-date.component.sass'],
})
export class ExclusionDateComponent extends BaseComponent {
    public scheduleValue: ISchedule;

    exclusionDatesDisplay: IExclusionDate[] = [];

    constructor(private dateAdapter: DateAdapter<Date>) {
        super();
    }

    @Input() set schedule(value: ISchedule | undefined) {
        this.scheduleValue = value ?? getDefaultSchedule(false);
        this.updateExclusionDatesDisplay();
    }

    updateExclusionDatesDisplay() {
        this.exclusionDatesDisplay = getUpdatedExclusionDatesDisplay(
            this.scheduleValue.exclusionDates,
            this.scheduleValue.timeZone.timeValue,
            this.dateAdapter,
        );
    }

    deleteExclusionDate(index: number) {
        const exclusionDateDisplayToDelete = this.exclusionDatesDisplay[index];
        const exclusionDateDisplaysToDeleteUtc = convertExclusionDateToOffset(
            exclusionDateDisplayToDelete,
            changeOffsetSign(this.scheduleValue.timeZone.timeValue),
            this.dateAdapter,
        );

        exclusionDateDisplaysToDeleteUtc.forEach((date) => {
            const sameDate = FindSameExclusionDateHelper(this.scheduleValue.exclusionDates, date);

            if (sameDate) {
                const initialDayTimeRangesLength = sameDate.dayTimeRanges.length;

                sameDate.dayTimeRanges = sameDate.dayTimeRanges.filter(
                    (range) =>
                        !date.dayTimeRanges.some(
                            (rangeToDelete) => rangeToDelete.start === range.start && rangeToDelete.end === range.end,
                        ),
                );

                sameDate.dayTimeRanges.forEach((range) => {
                    date.dayTimeRanges.forEach((rangeToDelete) => {
                        if (rangeToDelete.start === range.start && rangeToDelete.end < range.end) {
                            range.start = rangeToDelete.end;
                        } else if (rangeToDelete.end === range.end && rangeToDelete.start > range.start) {
                            range.end = rangeToDelete.start;
                        }
                    });
                });

                if (initialDayTimeRangesLength && !sameDate.dayTimeRanges.length) {
                    this.scheduleValue.exclusionDates.filter((d) => d !== sameDate);
                }
            }
        });

        this.updateExclusionDatesDisplay();
    }

    formatTime = (time: string) => time.substring(0, 5);
}
