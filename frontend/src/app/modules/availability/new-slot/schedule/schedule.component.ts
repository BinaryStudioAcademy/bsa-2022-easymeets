import { Component, Input, OnInit } from '@angular/core';
import { getDisplayDays } from '@core/helpers/display-days-helper';
import { getScheduleItems } from '@core/helpers/schedule-list-helper';
import { getPossibleTimeZones } from '@core/helpers/time-zone-helper';
import { IAvailabilitySlot } from '@core/models/IAvailiabilitySlot';
import { ISchedule } from '@core/models/schedule/ISchedule';

@Component({
    selector: 'app-schedule',
    templateUrl: './schedule.component.html',
    styleUrls: ['./schedule.component.sass'],
})
export class ScheduleComponent implements OnInit {
    @Input() set newSlot(value: IAvailabilitySlot | undefined) {
        this.slot = value;
        this.schedule = this.slot?.schedule ?? {
            timeZone: 0,
            withTeamMembers: false,
            scheduleItems: getScheduleItems(),
        };
    }

    public slot?: IAvailabilitySlot;

    public schedule: ISchedule;

    public displayDays: string[] = getDisplayDays();

    readonly timeZones: Map<number, string> = getPossibleTimeZones();

    public selectedTimeZone: string;

    ngOnInit(): void {
        this.selectedTimeZone = this.timeZones.get(this.schedule.timeZone) as string;
    }

    public changeTimeZone() {
        this.schedule.timeZone = this.getSelectedTimeZone();
    }

    private getSelectedTimeZone() {
        return [...this.timeZones].find(([, val]) => val === this.selectedTimeZone)![0];
    }
}
