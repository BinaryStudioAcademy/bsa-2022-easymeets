import { Component, EventEmitter, Input, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { BaseComponent } from '@core/base/base.component';
import { getDefaultSchedule } from '@core/helpers/default-schedule-helper';
import { getDisplayDays } from '@core/helpers/display-days-helper';
import { mergeExistingExclusionDates, sortDayTimeRanges } from '@core/helpers/exclusion-date-helper';
import { TimeRangesMergeHelper } from '@core/helpers/time-ranges-merge-helper';
import { ITimeZone } from '@core/models/ITimeZone';
import { IExclusionDate } from '@core/models/schedule/exclusion-date/IExclusionDate';
import { ISchedule } from '@core/models/schedule/ISchedule';
import { UserService } from '@core/services/user.service';
import { ExclusionDateComponent } from '@modules/availability/new-slot/schedule-definition/exclusion-date/exclusion-date.component';
import { ExclusionDatesPickerComponent } from '@modules/exclusion-dates/exclusion-dates-picker/exclusion-dates-picker.component';
import { TimeFormat } from '@shared/enums/timeFormat';

@Component({
    selector: 'app-schedule-definition',
    templateUrl: './schedule-definition.component.html',
    styleUrls: ['./schedule-definition.component.sass'],
})
export class ScheduleDefinitionComponent extends BaseComponent implements OnInit {
    @Input() changeEvent: EventEmitter<any> = new EventEmitter();

    @Input() set schedule(value: ISchedule | undefined) {
        this.scheduleValue = value ?? getDefaultSchedule(false);
    }

    @Input() disabled: boolean = false;

    @ViewChild(ExclusionDateComponent) exclusionDateComponent: ExclusionDateComponent;

    scheduleValue: ISchedule;

    displayDays: string[] = getDisplayDays();

    timeFormat?: TimeFormat;

    constructor(private userService: UserService) {
        super();
    }

    ngOnInit(): void {
        this.userService.userChangedEvent$.pipe(this.untilThis).subscribe((user) => {
            this.timeFormat = user?.timeFormat;
        });
    }

    checkZone = () => !this.scheduleValue.timeZone.nameValue;
}
