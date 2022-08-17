import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { IScheduleItem } from '@core/models/IScheduleItem';

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
        const hours: string = $event.target.value.substring(0, 2);
        const minutes: string = $event.target.value.substring(3, 5);

        if (isStart) {
            this.item.start.setHours(parseInt(hours, 10));
            this.item.start.setMinutes(parseInt(minutes, 10));
        } else {
            this.item.end.setHours(parseInt(hours, 10));
            this.item.end.setMinutes(parseInt(minutes, 10));
        }
        this.itemChange.emit(this.item);
    }

    ngOnInit(): void {
        this.startValue = `${this.item.start.getHours()}:${this.item.start.getMinutes()}`;
        this.endValue = `${this.item.end.getHours()}:${this.item.end.getMinutes()}`;
    }
}
