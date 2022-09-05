import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { BaseComponent } from '@core/base/base.component';
import { AuthService } from '@core/services/auth.service';
import { AuthFormService } from '@modules/auth/services/auth-form.service';
import { EmailValidator } from '@modules/auth/validators/email-validator';
import { PasswordsErrorStateMatcher } from '@modules/auth/validators/passwordsErrorStateMatcher';
import { userNameRegex } from '@shared/constants/model-validation';

@Component({
    selector: 'app-sign-up-form',
    templateUrl: './sign-up-form.component.html',
    styleUrls: ['./sign-up-form.component.sass', '../../shared-styles.sass'],
})
export class SignUpFormComponent extends BaseComponent {
    public matcher = new PasswordsErrorStateMatcher();

    public hidePassword = true;

    public signUpForm = new FormGroup({
        email: new FormControl('', {
            validators: [Validators.required, Validators.email],
            asyncValidators: [EmailValidator.signUpEmailValidator(this.authService)],
            updateOn: 'blur',
        }),
        name: new FormControl('', {
            validators: [
                Validators.required,
                Validators.minLength(3),
                Validators.maxLength(50),
                Validators.pattern(userNameRegex),
            ],
            updateOn: 'blur',
        }),
        password: new FormControl('', {
            validators: [Validators.required, Validators.minLength(8), Validators.maxLength(30)],
            updateOn: 'blur',
        }),
    });

    constructor(private authService: AuthService, private authFormService: AuthFormService) {
        super();
    }

    private setCredentialsIncorrect(): void {
        this.signUpForm.get('email')?.setErrors({ incorrectCredentials: true });
        this.signUpForm.get('name')?.setErrors({ incorrectCredentials: true });
        this.signUpForm.get('password')?.setErrors({ incorrectCredentials: true });
    }

    public onSignUp(): void {
        if (this.signUpForm.valid) {
            const email = this.signUpForm.value.email!;
            const password = this.signUpForm.value.password!;
            const name = this.signUpForm.value.name!;

            this.authFormService
                .signUp(email, password, name)
                .subscribe({ error: () => this.setCredentialsIncorrect() });
        }
    }

    public onSignInWithGoogle(): void {
        this.authFormService.onSignInWithGoogle().subscribe({ error: () => this.setCredentialsIncorrect() });
    }

    public getEmailErrorMessage(): string {
        if (this.signUpForm.controls.email.hasError('userAlreadyExists')) {
            return 'An account already exists with this email address';
        }

        return this.signUpForm.controls.email.invalid ? 'Email format is invalid' : '';
    }
}
