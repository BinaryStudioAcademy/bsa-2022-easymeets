import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { IScheduleItem } from '@core/models/new-availability-slot/IScheduleItem';

@Component({
    selector: 'app-schedule-list-item',
    templateUrl: './schedule-list-item.component.html',
    styleUrls: ['./schedule-list-item.component.sass'],
})
export class ScheduleListItemComponent implements OnInit {
    @Input() public item: IScheduleItem;

    @Output() public itemChange: EventEmitter<IScheduleItem> = new EventEmitter<IScheduleItem>();

    @Input() public displayDay: string;

    public startValue: string;

    public endValue: string;

    public onDateChange($event: any, isStart: boolean) {
        if (isStart) {
            this.item.start = `${$event.target.value}:00`;
        } else {
            this.item.end = `${$event.target.value}:00`;
        }
        this.onItemChange();
    }

    public onItemChange() {
        this.itemChange.emit(this.item);
    }

    ngOnInit(): void {
        this.startValue = this.item.start.substring(0, 5);
        this.endValue = this.item.end.substring(0, 5);
    }
}
