import { Component, Inject, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { DateAdapter } from '@angular/material/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { BaseComponent } from '@core/base/base.component';
import { convertExclusionDateToOffset } from '@core/helpers/exclusion-date-helper';
import { getTimeZoneHours, TimeRangeValidator } from '@core/helpers/time-helper';
import { getDateStringWithoutLocalOffset } from '@core/helpers/time-zone-helper';
import { ITimeZone } from '@core/models/ITimeZone';
import { IDayTimeRange } from '@core/models/schedule/exclusion-date/IDayTimeRange';
import { hourMinutesRegex } from '@shared/constants/model-validation';

@Component({
    selector: 'app-exclusion-dates-picker',
    templateUrl: './exclusion-dates-picker.component.html',
    styleUrls: ['./exclusion-dates-picker.component.sass'],
})
export class ExclusionDatesPickerComponent extends BaseComponent implements OnInit {
    selected: Date | null;

    timeIndexIdSeed = 1;

    timeControlsIdentifiers: number[] = [0];

    formGroup: FormGroup;

    readonly startRangeIdentifier = 'startRange';

    readonly endRangeIdentifier = 'endRange';

    constructor(
        private dialogRef: MatDialogRef<ExclusionDatesPickerComponent>,
        @Inject(MAT_DIALOG_DATA) private scheduleTimeZone: ITimeZone,
        private dateAdapter: DateAdapter<Date>,
    ) {
        super();
    }

    ngOnInit() {
        this.formGroup = this.getDefaultFormGroup();
    }

    addTimeItem() {
        const [firstTimeControl, secondTimeControl] = this.getTimeFormControls();

        this.formGroup.addControl(this.timeIndexIdSeed.toString() + this.startRangeIdentifier, firstTimeControl);
        this.formGroup.addControl(this.timeIndexIdSeed.toString() + this.endRangeIdentifier, secondTimeControl);
        this.timeControlsIdentifiers = [...this.timeControlsIdentifiers, this.timeIndexIdSeed];
        this.timeIndexIdSeed++;
    }

    removeTimeItem(controlsIdentifier: number) {
        this.formGroup.removeControl(controlsIdentifier.toString() + this.startRangeIdentifier);
        this.formGroup.removeControl(controlsIdentifier.toString() + this.endRangeIdentifier);
        this.timeControlsIdentifiers = this.timeControlsIdentifiers.filter(
            (identifier) => identifier !== controlsIdentifier,
        );
    }

    clickApply() {
        if (!this.selected) {
            this.dialogRef.close();

            return;
        }
        this.dialogRef.close(
            convertExclusionDateToOffset(
                {
                    selectedDate: getDateStringWithoutLocalOffset(this.selected),
                    dayTimeRanges: this.getTimeRanges(),
                },
                getTimeZoneHours(this.scheduleTimeZone.timeValue),
                this.dateAdapter,
            ),
        );
    }

    clickCancel() {
        this.dialogRef.close();
    }

    getValidDayTimeRanges = () =>
        this.timeControlsIdentifiers
            .map((number) => ({
                start: this.formGroup.get(number.toString() + this.startRangeIdentifier)?.value ?? '' as string,
                end: this.formGroup.get(number.toString() + this.endRangeIdentifier)?.value ?? '' as string,
            }))
            .filter((range) => range.start && range.end)
            .map((range) => ({
                start: {
                    hour: Number(range.start.substring(0, 2)),
                    minute: Number(range.start.substring(3, 5)),
                },
                end: {
                    hour: Number(range.end.substring(0, 2)),
                    minute: Number(range.end.substring(3, 5)),
                },
            }));

    getTimeRanges(): IDayTimeRange[] {
        const validTimeRanges = this.getValidDayTimeRanges();

        return validTimeRanges.length
            ? validTimeRanges
            : [{ start: { hour: 0, minute: 0 }, end: { hour: 23, minute: 59 } }];
    }

    private getDefaultFormGroup = () => {
        const [firstTimeControl, secondTimeControl] = this.getTimeFormControls();

        return new FormGroup({
            [`0${this.startRangeIdentifier}`]: firstTimeControl,
            [`0${this.endRangeIdentifier}`]: secondTimeControl,
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
