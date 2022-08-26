import { FormControl, FormGroupDirective, NgForm } from '@angular/forms';
import { ErrorStateMatcher } from '@angular/material/core';

export class PasswordsErrorStateMatcher implements ErrorStateMatcher {
    passwordsMismatch = false;

    isErrorState(control: FormControl | null, formGroupDirective: FormGroupDirective | NgForm | null): boolean {
        const password = formGroupDirective?.form.controls['password'].value
            ? formGroupDirective?.form.controls['password'].value
            : undefined;
        const confirmPassword = control?.value ? control?.value : undefined;

        this.passwordsMismatch = !(password === confirmPassword);

        if (this.passwordsMismatch) {
            control?.setErrors({ incorrectCredentials: true });
        } else {
            control?.updateValueAndValidity();
        }

        return this.passwordsMismatch;
    }
}
