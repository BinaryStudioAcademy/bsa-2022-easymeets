import { Component, EventEmitter, Input, OnInit } from '@angular/core';
import { getDisplayDays } from '@core/helpers/display-days-helper';
import { ISchedule } from '@core/models/schedule/ISchedule';
import { TZone } from 'moment-timezone-picker';

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

    selectedTimeZone: TZone;

    ngOnInit(): void {
        this.selectedTimeZone = {
            timeValue: this.schedule.timeZoneValue,
            nameValue: this.schedule.timeZoneName,
            abbr: '',
            name: '',
            group: '',
        };
    }

    public changeZone(event: TZone) {
        if (event.nameValue && event.timeValue) {
            this.schedule.timeZoneName = this.selectedTimeZone.name;
            this.schedule.timeZoneValue = this.selectedTimeZone.timeValue;
        }
    }
}
