import { AbstractControl, ValidationErrors, ValidatorFn } from '@angular/forms';
import { datesEqual } from '@core/helpers/date-helper';

export interface DateFunc {
    (): Date | null;
}

export function MinimalTimeValidator(selectedDateFunc: DateFunc): ValidatorFn {
    return (control: AbstractControl): ValidationErrors | null => {
        const selectedDate = selectedDateFunc();

        console.log(selectedDate);
        console.log('validator runs');

        if (selectedDate && !datesEqual(selectedDate, new Date())) {
            return null;
        }

        return control?.value >
            new Date().toLocaleTimeString('en-US', {
                hour: '2-digit',
                minute: '2-digit',
                hourCycle: 'h23',
            })
            ? null
            : { error: true };
    };
}

export function TimeRangeValidator(firstControl: AbstractControl): ValidatorFn {
    return (control: AbstractControl): ValidationErrors | null =>
        (firstControl?.value < control?.value ? null : { error: true });
}
