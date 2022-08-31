import { Component, EventEmitter, Input, OnInit } from '@angular/core';
import { getDisplayDays } from '@core/helpers/display-days-helper';
import { getPossibleTimeZones } from '@core/helpers/time-zone-helper';
import { ITimeZone } from '@core/models/ITimeZone';
import { ISchedule } from '@core/models/schedule/ISchedule';

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
}
