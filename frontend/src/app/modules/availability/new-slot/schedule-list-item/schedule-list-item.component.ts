import { Component, EventEmitter, Input, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { BaseComponent } from '@core/base/base.component';
import { IScheduleItem } from '@core/models/schedule/IScheduleItem';
import { hourMinutesRegex } from '@shared/constants/model-validation';

@Component({
    selector: 'app-schedule-list-item',
    templateUrl: './schedule-list-item.component.html',
    styleUrls: ['./schedule-list-item.component.sass'],
})
export class ScheduleListItemComponent extends BaseComponent implements OnInit {
    @Input() item: IScheduleItem;

    @Input() displayDay: string;

    @Input() itemChange: EventEmitter<void> = new EventEmitter();

    startValue: string;

    endValue: string;

    scheduleForm = new FormGroup({
        startTime: new FormControl('', [Validators.pattern(hourMinutesRegex)]),
        endTime: new FormControl('', [Validators.pattern(hourMinutesRegex)]),
    });

    onDateChange($event: Event, isStart: boolean) {
        const target = $event.target as HTMLInputElement;
        const dateValue = `${target.value}:00`;

        if (isStart) {
            this.item.start = dateValue;
        } else {
            this.item.end = dateValue;
        }
        this.onItemChange();
    }

    onItemChange() {
        this.itemChange.emit();
    }

    ngOnInit(): void {
        this.itemChange
            .pipe(this.untilThis)
            .subscribe(() => {
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
