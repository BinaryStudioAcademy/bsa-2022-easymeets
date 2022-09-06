import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { MatDialogRef } from '@angular/material/dialog';
import { IDayTimeRange } from '@core/models/schedule/exclusion-date/IDayTimeRange';
import { hourMinutesRegex } from '@shared/constants/model-validation';

@Component({
    selector: 'app-exclusion-dates-picker',
    templateUrl: './exclusion-dates-picker.component.html',
    styleUrls: ['./exclusion-dates-picker.component.sass'],
})
export class ExclusionDatesPickerComponent implements OnInit {
    selected: Date | null;

    currentTimeItemIndex = 1;

    formGroup: FormGroup;

    // eslint-disable-next-line no-empty-function
    constructor(private dialogRef: MatDialogRef<ExclusionDatesPickerComponent>) { }

    ngOnInit() {
        this.formGroup = this.getDefaultFormGroup();
    }

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
        if (!this.selected) {
            this.dialogRef.close();

            return;
        }
        this.dialogRef.close({
            selectedDate: this.selected,
            dayTimeRanges: this.getValidDayTimeRanges(),
        });
    }

    clickCancel() {
        this.dialogRef.close();
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

    private getDefaultFormGroup = () =>
        new FormGroup({
            '00': new FormControl('', [Validators.pattern(hourMinutesRegex)]),
            '01': new FormControl('', [Validators.pattern(hourMinutesRegex)]),
        });
}
