import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthService } from '@core/services/auth.service';
import { PasswordsErrorStateMatcher } from '@modules/auth/validators/passwordsErrorStateMatcher';

@Component({
    selector: 'app-sign-up-form',
    templateUrl: './sign-up-form.component.html',
    styleUrls: ['./sign-up-form.component.sass', '../../shared-styles.sass'],
})
export class SignUpFormComponent {
    public matcher = new PasswordsErrorStateMatcher();

    public hidePassword = true;

    public signUpForm = new FormGroup({
        email: new FormControl('', { validators: [Validators.required, Validators.email], updateOn: 'submit' }),
        name: new FormControl('', {
            validators: [
                Validators.required,
                Validators.minLength(3),
                Validators.maxLength(50),
                Validators.pattern('^[a-zA-Zа-яА-Я0-9- ]+$'),
            ],
            updateOn: 'submit',
        }),
        password: new FormControl('', {
            validators: [Validators.required, Validators.minLength(8), Validators.maxLength(30)],
            updateOn: 'blur',
        }),
        confirmPassword: new FormControl('', { updateOn: 'blur' }),
    });

    // eslint-disable-next-line no-empty-function
    constructor(private authService: AuthService, private router: Router) {}

    private setCredentialsIncorrect() {
        this.signUpForm.get('email')?.setErrors({ incorrectCredentials: true });
        this.signUpForm.get('name')?.setErrors({ incorrectCredentials: true });
        this.signUpForm.get('password')?.setErrors({ incorrectCredentials: true });
    }

    private handleAuthenticationResponce(resp: any): void {
        if (resp) {
            this.router.navigateByUrl('main');
        } else {
            this.setCredentialsIncorrect();
        }
    }

    public onSignUp(): void {
        if (this.signUpForm.valid) {
            const email = this.signUpForm.value.email ?? '';
            const password = this.signUpForm.value.password ?? '';

            this.authService.signUp(email, password).then((resp) => this.handleAuthenticationResponce(resp));
        }
    }

    public onSignInWithGoogle(): void {
        this.authService.loginWithGoogle().then((resp) => this.handleAuthenticationResponce(resp));
    }
}
