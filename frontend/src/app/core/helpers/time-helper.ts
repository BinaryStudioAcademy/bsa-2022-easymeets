import { AbstractControl, ValidationErrors, ValidatorFn } from '@angular/forms';

export function TimeRangeValidator(firstControl: AbstractControl): ValidatorFn {
    return (control: AbstractControl): ValidationErrors | null =>
        (firstControl?.value < control?.value ? null : { error: true });
}
