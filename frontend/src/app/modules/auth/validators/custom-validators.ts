import { AbstractControl, ValidationErrors, ValidatorFn } from '@angular/forms';

import { Utils } from '../utils';

export class CustomValidators {
    static passwordsMatching: ValidatorFn = (form: AbstractControl<any, any>): ValidationErrors | null => {
        const { password } = form.value;
        const { confirmPassword } = form.value;

        return Utils.passwordsMatch(password, confirmPassword) ? null : { not_matching: true };
    };
}
