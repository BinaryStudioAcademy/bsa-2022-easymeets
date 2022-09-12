import { Component, EventEmitter, Input, OnInit } from '@angular/core';
import { getDefaultSchedule } from '@core/helpers/default-schedule-helper';
import { getDisplayDays } from '@core/helpers/display-days-helper';
import { ISchedule } from '@core/models/schedule/ISchedule';
import { UserService } from '@core/services/user.service';
import { TimeFormat } from '@shared/enums/timeFormat';

@Component({
    selector: 'app-schedule-definition',
    templateUrl: './schedule-definition.component.html',
    styleUrls: ['./schedule-definition.component.sass'],
})
export class ScheduleDefinitionComponent implements OnInit {
    @Input() changeEvent: EventEmitter<any> = new EventEmitter();

    @Input() set schedule(value: ISchedule | undefined) {
        this.scheduleValue = value ?? getDefaultSchedule(false);
    }

    public scheduleValue: ISchedule;

    @Input() disabled: boolean = false;

    displayDays: string[] = getDisplayDays();

    timeFormat?: TimeFormat;

    // eslint-disable-next-line no-empty-function
    constructor(private userService: UserService) {}

    ngOnInit(): void {
        const user = this.userService.getLocalUser();

        this.timeFormat = user ? user.timeFormat : TimeFormat.TwentyFourHour;
    }

    public checkZone(): boolean {
        return !this.scheduleValue.timeZone.nameValue;
    }
}
