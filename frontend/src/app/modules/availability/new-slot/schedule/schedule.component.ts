import { Component, Input, OnInit } from '@angular/core';
import { getScheduleItems } from '@core/helpers/schedule-list-helper';
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

    public displayDays: string[] = ['Sun', 'Mon', 'Tue', 'Wen', 'Thu', 'Fri', 'Sat'];

    public timeZones: string[] = ['Eastern Europe (+3:00 GMT)', 'British summer time (+1:00 GMT)'];

    public selectedTimeZone: string;

    ngOnInit(): void {
        this.selectedTimeZone = this.timeZones[this.schedule.timeZone];
    }
}
