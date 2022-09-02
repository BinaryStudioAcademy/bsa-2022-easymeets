import { Component, EventEmitter, Input } from '@angular/core';
import { getDefaultSchedule } from '@core/helpers/default-schedule-helper';
import { getDisplayDays } from '@core/helpers/display-days-helper';
import { ISchedule } from '@core/models/schedule/ISchedule';

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
        return this.scheduleValue.timeZone.nameValue === '';
    }
}
