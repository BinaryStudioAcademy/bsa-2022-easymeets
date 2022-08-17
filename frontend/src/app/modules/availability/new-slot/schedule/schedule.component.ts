import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { getScheduleItems } from '@core/helpers/schedule-list-helper';
import { IScheduleItem } from '@core/models/IScheduleItem';

@Component({
    selector: 'app-schedule',
    templateUrl: './schedule.component.html',
    styleUrls: ['./schedule.component.sass'],
})
export class ScheduleComponent implements OnInit {
    @Input() public items: IScheduleItem[];

    @Output() public itemsChange: EventEmitter<IScheduleItem[]> = new EventEmitter<IScheduleItem[]>();

    public displayDays: string[] = ['Sun', 'Mon', 'Tue', 'Wen', 'Thu', 'Fri', 'Sat'];

    public timeZones: string[] = ['Eastern Europe (+3:00 GMT)', 'British summer time (+1:00 GMT)'];

    public selectedTimeZone: string = this.timeZones[0];

    ngOnInit(): void {
        if (this.items === undefined) {
            this.items = getScheduleItems();
        }
    }
}
