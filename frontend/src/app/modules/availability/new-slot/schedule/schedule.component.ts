import { Component, EventEmitter, Input, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { getDisplayDays } from '@core/helpers/display-days-helper';
import { getScheduleItems } from '@core/helpers/schedule-list-helper';
import { TimeZoneFullNameMapper } from '@core/helpers/time-zone-helper';
import { IAvailabilitySlot } from '@core/models/IAvailabilitySlot';
import { ISchedule } from '@core/models/schedule/ISchedule';
import { TZone } from 'moment-timezone-picker';

@Component({
    selector: 'app-schedule',
    templateUrl: './schedule.component.html',
    styleUrls: ['./schedule.component.sass'],
})
export class ScheduleComponent implements OnInit {
    @Input() set newSlot(value: IAvailabilitySlot | undefined) {
        this.slot = value;
        this.schedule = this.slot?.schedule ?? {
            timeZoneValue: '',
            timeZoneName: '',
            withTeamMembers: false,
            scheduleItems: getScheduleItems(),
        };
        if (this.slot) {
            this.scheduleForm.patchValue({
                timeZone: this.timeZoneMapping(this.slot?.schedule.timeZoneName ?? this.defaultTimeZone),
            });
        }
    }

    public timeZoneMapping = TimeZoneFullNameMapper;

    changeEvent: EventEmitter<any> = new EventEmitter();

    slot?: IAvailabilitySlot;

    schedule: ISchedule;

    displayDays: string[] = getDisplayDays();

    public scheduleForm: FormGroup;

    private defaultTimeZone = 'Europe/Kiev (+03:00)';

    public ngOnInit(): void {
        this.scheduleForm = new FormGroup({
            timeZone: new FormControl(),
        });
        this.scheduleForm.patchValue({
            timeZone: this.timeZoneMapping(this.slot?.schedule.timeZoneName ?? this.defaultTimeZone),
        });
    }

    public changeZone(event: TZone) {
        if (event.nameValue && event.timeValue) {
            this.schedule.timeZoneName = this.scheduleForm.value.timeZone.name;
            this.schedule.timeZoneValue = this.scheduleForm.value.timeZone.timeValue;
        }
    }
}
