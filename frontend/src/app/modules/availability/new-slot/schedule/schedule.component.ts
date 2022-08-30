import { Component, EventEmitter, Input } from '@angular/core';
import { getScheduleItems } from '@core/helpers/schedule-list-helper';
import { IAvailabilitySlot } from '@core/models/IAvailabilitySlot';
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
            definedExternally: false,
            definedBy: undefined,
        };
    }

    changeEvent: EventEmitter<any> = new EventEmitter();

    slot?: IAvailabilitySlot;

    schedule: ISchedule;
}
