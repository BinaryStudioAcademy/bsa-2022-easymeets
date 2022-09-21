import { AbstractControl, ValidationErrors, ValidatorFn } from '@angular/forms';

export const TimeRangeValidator =
    (firstControl: AbstractControl): ValidatorFn =>
        (control: AbstractControl): ValidationErrors | null =>
            (firstControl?.value < control?.value ? null : { error: true });

export const getTimeZoneHours = (timeZoneValue: string) => Number(timeZoneValue.substring(0, 3));
