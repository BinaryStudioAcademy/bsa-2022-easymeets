import { AbstractControl, AsyncValidatorFn } from '@angular/forms';
import { AuthService } from '@core/services/auth.service';
import { map } from 'rxjs';

export class EmailValidator {
    static signUpEmailValidator(authService: AuthService): AsyncValidatorFn {
        return (control: AbstractControl) =>
            authService
                .checkEmail(control.value)
                .pipe(map((result: boolean) => (result ? { userAlreadyExists: true } : null)));
    }
}
