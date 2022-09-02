import { Component, EventEmitter, OnInit, Output, ViewEncapsulation } from '@angular/core';
import { MatCalendarCellClassFunction } from '@angular/material/datepicker';
import { ExclusionDatesService } from '@core/services/exclusion-dates-service';
import { HeaderDatePickerComponent } from '@modules/exclusion-dates/header-date-picker/header-date-picker.component';
import { FormControl, FormGroup, Validators } from "@angular/forms";

export interface DateItem {
    start?: string;
    end?: string
}

export interface ExclusionDates {
    selectedDate: Date | null,
    hours: DateItem[]
}

@Component({
    selector: 'app-exclusion-dates-picker',
    templateUrl: './exclusion-dates-picker.component.html',
    styleUrls: ['./exclusion-dates-picker.component.sass'],
    encapsulation: ViewEncapsulation.None,
})
export class ExclusionDatesPickerComponent implements OnInit {
    todayDate: Date = new Date();

    selected: Date | null;

    currentTimeItemIndex = 0

    customHeader = HeaderDatePickerComponent;

    formGroup: FormGroup;

    @Output() datesEmitter: EventEmitter<ExclusionDates>;

    constructor(public exclusionDatesService: ExclusionDatesService) {
        this.datesEmitter = new EventEmitter<ExclusionDates>();
    }

    ngOnInit() {
        this.formGroup = new FormGroup({});
    }

    dateClass: MatCalendarCellClassFunction<Date> = (cellDate, view) => {
        if (view === 'month') {
            const selectedDate = new Date(cellDate.getFullYear(), cellDate.getMonth(), cellDate.getDate());

            if (selectedDate.getDate() === this.todayDate.getDate() &&
                selectedDate.getMonth() === this.todayDate.getMonth() &&
                selectedDate.getFullYear() === this.todayDate.getFullYear()) {
                return 'current-day cell';
            }
            if (selectedDate.getDate() === this.selected?.getDate() &&
                selectedDate.getMonth() === this.selected?.getMonth() &&
                selectedDate.getFullYear() === this.selected?.getFullYear()) {
                return 'selected-day cell';
            }
            if (selectedDate >= this.todayDate) {
                return 'test-class cell';
            }
        }

        return '';
    };

    addTimeItem() {
        this.formGroup.addControl(this.currentTimeItemIndex.toString() + '0', new FormControl(''));
        this.formGroup.addControl(this.currentTimeItemIndex.toString() + '1', new FormControl(''));
        this.currentTimeItemIndex++;
    }

    removeTimeItem() {
        this.currentTimeItemIndex--;
        this.formGroup.removeControl(this.currentTimeItemIndex.toString() + '0');
        this.formGroup.removeControl(this.currentTimeItemIndex.toString() + '1');
    }

    clickApply() {
        this.exclusionDatesService.hide();
        this.datesEmitter.emit({
            selectedDate: this.selected,
            hours: this.getIndexSequence().map(number => {
                return {
                    start: this.formGroup.get(number.toString() + '0')?.value,
                    end: this.formGroup.get(number.toString() + '1')?.value
                }
            })
        });
    }

    getIndexSequence = () => [...Array(this.currentTimeItemIndex).keys()];
}
