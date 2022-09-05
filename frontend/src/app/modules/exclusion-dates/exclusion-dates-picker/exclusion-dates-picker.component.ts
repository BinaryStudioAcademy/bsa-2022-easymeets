import { Component, EventEmitter, OnInit, Output, ViewEncapsulation } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { MatCalendarCellClassFunction } from '@angular/material/datepicker';
import { IDayTimeRange } from '@core/models/schedule/exclusion-date/IDayTimeRange';
import { IExclusionDate } from '@core/models/schedule/exclusion-date/IExclusionDate';
import { ExclusionDatesService } from '@core/services/exclusion-dates-service';
import { HeaderDatePickerComponent } from '@modules/exclusion-dates/header-date-picker/header-date-picker.component';
import { hourMinutesRegex } from "@shared/constants/model-validation";

@Component({
    selector: 'app-exclusion-dates-picker',
    templateUrl: './exclusion-dates-picker.component.html',
    styleUrls: ['./exclusion-dates-picker.component.sass'],
    encapsulation: ViewEncapsulation.None,
})
export class ExclusionDatesPickerComponent implements OnInit {
    todayDate: Date = new Date();

    selected: Date | null;

    currentTimeItemIndex = 1;

    customHeader = HeaderDatePickerComponent;

    formGroup: FormGroup;

    @Output() datesEmitter: EventEmitter<IExclusionDate>;

    constructor(public exclusionDatesService: ExclusionDatesService) {
        this.datesEmitter = new EventEmitter<IExclusionDate>();
    }

    ngOnInit() {
        this.formGroup = new FormGroup({
            '00': new FormControl('', [Validators.pattern(hourMinutesRegex)]),
            '01': new FormControl('', [Validators.pattern(hourMinutesRegex)]),
        });
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
        this.formGroup.addControl(`${this.currentTimeItemIndex.toString()}0`, new FormControl());
        this.formGroup.addControl(`${this.currentTimeItemIndex.toString()}1`, new FormControl());
        this.currentTimeItemIndex++;
    }

    removeTimeItem() {
        this.currentTimeItemIndex--;
        this.formGroup.removeControl(`${this.currentTimeItemIndex.toString()}0`);
        this.formGroup.removeControl(`${this.currentTimeItemIndex.toString()}1`);
    }

    clickApply() {
        this.exclusionDatesService.hide();
        if (this.selected) {
            this.datesEmitter.emit({
                selectedDate: this.selected,
                dayTimeRanges: this.getValidDayTimeRanges(),
            });
        }
    }

    getIndexSequence = () => [...Array(this.currentTimeItemIndex).keys()];

    getValidDayTimeRanges() {
        const validDayTimeRanges: IDayTimeRange[] = [];

        this.getIndexSequence().forEach(number => {
            const start: string | null = this.formGroup.get(`${number.toString()}0`)?.value;
            const end: string | null = this.formGroup.get(`${number.toString()}1`)?.value;

            if (start && end) {
                validDayTimeRanges.push({ start, end });
            }
        });

        return validDayTimeRanges;
    }
}
