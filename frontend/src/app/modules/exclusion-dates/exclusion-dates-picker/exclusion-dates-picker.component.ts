import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { MatDialogRef } from '@angular/material/dialog';
import { BaseComponent } from '@core/base/base.component';
import { IDayTimeRange } from '@core/models/schedule/exclusion-date/IDayTimeRange';
import { TimeRangeValidator } from '@modules/exclusion-dates/validators/time-range-validator';
import { hourMinutesRegex } from '@shared/constants/model-validation';

@Component({
    selector: 'app-exclusion-dates-picker',
    templateUrl: './exclusion-dates-picker.component.html',
    styleUrls: ['./exclusion-dates-picker.component.sass'],
})
export class ExclusionDatesPickerComponent extends BaseComponent implements OnInit {
    selected: Date | null;

    currentTimeItemIndex = 1;

    formGroup: FormGroup;

    constructor(private dialogRef: MatDialogRef<ExclusionDatesPickerComponent>) {
        super();
    }

    ngOnInit() {
        this.formGroup = this.getDefaultFormGroup();
    }

    addTimeItem() {
        const [firstTimeControl, secondTimeControl] = this.getTimeFormControls();

        this.formGroup.addControl(`${this.currentTimeItemIndex.toString()}0`, firstTimeControl);
        this.formGroup.addControl(`${this.currentTimeItemIndex.toString()}1`, secondTimeControl);
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

        this.getIndexSequence().forEach((number) => {
            const start: string | null = this.formGroup.get(`${number.toString()}0`)?.value;
            const end: string | null = this.formGroup.get(`${number.toString()}1`)?.value;

            if (start && end) {
                validDayTimeRanges.push({ start, end });
            }
        });

        return validDayTimeRanges;
    }

    private getDefaultFormGroup = () => {
        const [firstTimeControl, secondTimeControl] = this.getTimeFormControls();

        return new FormGroup({
            '00': firstTimeControl,
            '01': secondTimeControl,
        });
    };

    private getTimeFormControls = () => {
        const firstControl = new FormControl(null, {
            validators: [Validators.pattern(hourMinutesRegex)],
            updateOn: 'change',
        });

        return [
            firstControl,
            new FormControl(null, {
                validators: [Validators.pattern(hourMinutesRegex), TimeRangeValidator(firstControl)],
                updateOn: 'change',
            }),
        ];
    };
}
