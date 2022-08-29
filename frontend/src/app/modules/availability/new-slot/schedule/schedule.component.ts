import { Component, EventEmitter, Input } from '@angular/core';
import { getDisplayDays } from '@core/helpers/display-days-helper';
import { getScheduleItems } from '@core/helpers/schedule-list-helper';
import { getPossibleTimeZones } from '@core/helpers/time-zone-helper';
import { IAvailabilitySlot } from '@core/models/IAvailabilitySlot';
import { ITimeZone } from '@core/models/ITimeZone';
import { ISchedule } from '@core/models/schedule/ISchedule';

@Component({
    selector: 'app-schedule',
    templateUrl: './schedule.component.html',
    styleUrls: ['./schedule.component.sass'],
})
export class ScheduleComponent {
    @Input() set newSlot(value: IAvailabilitySlot | undefined) {
        this.slot = value;
        this.schedule = this.slot?.schedule ?? {
            timeZone: 0,
            withTeamMembers: false,
            scheduleItems: getScheduleItems(),
        };
        this.selectedTimeZone = this.getDisplayTimeZone(this.schedule.timeZone);
    }

    changeEvent: EventEmitter<any> = new EventEmitter();

    slot?: IAvailabilitySlot;

    schedule: ISchedule;

    displayDays: string[] = getDisplayDays();

    readonly timeZones: ITimeZone[] = getPossibleTimeZones();

    selectedTimeZone: string;

    changeTimeZone() {
        this.schedule.timeZone = this.getSelectedTimeZoneValue();
    }

    getSelectedTimeZoneValue() {
        return this.timeZones.find((x) => x.displayValue === this.selectedTimeZone)!.value;
    }

    getDisplayTimeZone(value: number) {
        return this.timeZones.find((x) => x.value === value)!.displayValue;
    }
}
