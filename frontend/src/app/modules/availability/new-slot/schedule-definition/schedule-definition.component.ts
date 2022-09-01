import { Component, EventEmitter, Input } from '@angular/core';
import { getDefaultSchedule } from '@core/helpers/default-schedule-helper';
import { getDisplayDays } from '@core/helpers/display-days-helper';
import { TimeZoneFullNameMapper } from '@core/helpers/time-zone-helper';
import { ITimeZone } from '@core/models/ITimeZone';
import { ISchedule } from '@core/models/schedule/ISchedule';
import { TZone } from 'moment-timezone-picker';

@Component({
    selector: 'app-schedule-definition',
    templateUrl: './schedule-definition.component.html',
    styleUrls: ['./schedule-definition.component.sass'],
})
export class ScheduleDefinitionComponent {
    @Input() changeEvent: EventEmitter<any> = new EventEmitter();

    @Input() set schedule(value: ISchedule | undefined) {
        this.scheduleValue = value ?? getDefaultSchedule(false);
        this.selectedTimeZone = this.timeZoneMapping(this.scheduleValue.timeZoneName);
    }

    public scheduleValue: ISchedule;

    @Input() disabled: boolean = false;

    displayDays: string[] = getDisplayDays();

    public timeZoneMapping = TimeZoneFullNameMapper;

    selectedTimeZone: ITimeZone;

    public changeZone(event: TZone) {
        if (event.nameValue && event.timeValue) {
            this.scheduleValue.timeZoneName = event.name;
            this.scheduleValue.timeZoneValue = event.timeValue;
        }
    }

    public checkZone(): boolean {
        return this.selectedTimeZone.nameValue === '';
    }
}
