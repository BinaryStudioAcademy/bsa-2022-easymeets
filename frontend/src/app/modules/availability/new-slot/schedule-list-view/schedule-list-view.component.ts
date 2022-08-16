import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { getScheduleItems } from '@core/helpers/schedule-list-helper';
import { IScheduleItem } from '@core/models/IScheduleItem';

@Component({
    selector: 'app-schedule-list-view',
    templateUrl: './schedule-list-view.component.html',
    styleUrls: ['./schedule-list-view.component.sass'],
})
export class ScheduleListViewComponent implements OnInit {
    @Input() public items: IScheduleItem[];

    @Output() public itemsChange: EventEmitter<IScheduleItem[]> = new EventEmitter<IScheduleItem[]>();

    ngOnInit(): void {
        if (this.items === undefined) {
            this.items = getScheduleItems();
        }
    }
}
