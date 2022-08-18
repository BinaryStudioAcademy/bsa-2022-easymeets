import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { IScheduleItem } from '@core/models/schedule/IScheduleItem';

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

    public onDateChange($event: Event, isStart: boolean) {
        const target = $event.target as HTMLInputElement;
        const dateValue = `${target.value}:00`;

        if (isStart) {
            this.item.start = dateValue;
        } else {
            this.item.end = dateValue;
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
