import { Component, EventEmitter, Input, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { IScheduleItem } from '@core/models/schedule/IScheduleItem';
import { timeNumberRegex } from '@shared/constants/model-validation';

@Component({
    selector: 'app-schedule-list-item',
    templateUrl: './schedule-list-item.component.html',
    styleUrls: ['./schedule-list-item.component.sass'],
})
export class ScheduleListItemComponent implements OnInit {
    @Input() public item: IScheduleItem;

    @Input() public displayDay: string;

    @Input() public itemChange: EventEmitter<void> = new EventEmitter();

    public startValue: string;

    public endValue: string;

    public scheduleForm = new FormGroup({
        startTime: new FormControl('', [Validators.pattern(timeNumberRegex)]),
        endTime: new FormControl('', [Validators.pattern(timeNumberRegex)]),
    });

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
        this.itemChange.emit();
    }

    public ngOnInit(): void {
        this.itemChange.subscribe(() => {
            this.updateTime();
        });
        this.updateTime();
    }

    get startTime() {
        return this.scheduleForm.get('startTime');
    }

    get endTime() {
        return this.scheduleForm.get('endTime');
    }

    private updateTime() {
        this.scheduleForm.patchValue({
            startTime: this.item.start.substring(0, 5),
            endTime: this.item.end.substring(0, 5),
        });
        this.startValue = this.item.start.substring(0, 5);
        this.endValue = this.item.end.substring(0, 5);
    }
}
