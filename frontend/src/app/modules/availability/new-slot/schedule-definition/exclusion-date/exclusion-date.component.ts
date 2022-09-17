import { Component, Input } from '@angular/core';
import { getDefaultSchedule } from '@core/helpers/default-schedule-helper';
import { ISchedule } from '@core/models/schedule/ISchedule';

@Component({
    selector: 'app-exclusion-date',
    templateUrl: './exclusion-date.component.html',
    styleUrls: ['./exclusion-date.component.sass'],
})
export class ExclusionDateComponent {
    public scheduleValue: ISchedule;

    @Input() set schedule(value: ISchedule | undefined) {
        this.scheduleValue = value ?? getDefaultSchedule(false);
    }

    formatTime = (time: string) => time.substring(0, 5);

    deleteExclusionDate(index: number) {
        this.scheduleValue.exclusionDates = this.scheduleValue.exclusionDates.filter(
            (date, dateIndex) => dateIndex !== index,
        );
    }
}
