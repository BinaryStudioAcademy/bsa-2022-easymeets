import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { BaseComponent } from '@core/base/base.component';
import { AuthService } from '@core/services/auth.service';
import { AuthFormService } from '@core/services/auth-form.service';
import { EmailValidator } from '@modules/auth/validators/email-validator';
import firebase from 'firebase/compat/app';

@Component({
    selector: 'app-sign-in-form',
    templateUrl: './sign-in-form.component.html',
    styleUrls: ['./sign-in-form.component.sass', '../../shared-styles.sass'],
})
export class SignInFormComponent extends BaseComponent {
    public hidePassword = true;

    public signInForm = new FormGroup(
        {
            email: new FormControl(
                '',
                [Validators.required, Validators.email],
                [EmailValidator.loginEmailValidator(this.authService)],
            ),
            password: new FormControl('', [Validators.required, Validators.minLength(8)]),
        },
        {
            updateOn: 'blur',
        },
    );

    constructor(private authService: AuthService, private authFormService: AuthFormService) {
        super();
    }

    private setCredentialsIncorrect() {
        this.signInForm.get('password')?.setErrors({ incorrectCredentials: true });
    }

    public onSignIn(): void {
        if (this.signInForm.valid) {
            this.authFormService
                .signIn(this.signInForm.value.email!, this.signInForm.value.password!)
                .subscribe({ error: (e: firebase.auth.Error) => {
                    if (e.code && e.code === 'auth/wrong-password') {
                        this.setCredentialsIncorrect();
                    }
                } });
        }
    }

    public onSignInWithGoogle(): void {
        this.authFormService.onSignInWithGoogle().subscribe({ error: () => this.setCredentialsIncorrect() });
    }
}
