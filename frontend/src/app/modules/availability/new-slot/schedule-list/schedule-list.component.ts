import { Component, EventEmitter, Input } from '@angular/core';
import { IScheduleItem } from '@core/models/schedule/IScheduleItem';
import { TimeFormat } from '@shared/enums/timeFormat';

@Component({
    selector: 'app-schedule-list',
    templateUrl: './schedule-list.component.html',
    styleUrls: ['./schedule-list.component.sass'],
})
export class ScheduleListComponent {
    @Input() changeEvent: EventEmitter<any> = new EventEmitter();

    @Input() scheduleItems: IScheduleItem[];

    @Input() disabled: boolean;

    @Input() timeFormat?: TimeFormat;

    @Input() displayDays: string[];
}
