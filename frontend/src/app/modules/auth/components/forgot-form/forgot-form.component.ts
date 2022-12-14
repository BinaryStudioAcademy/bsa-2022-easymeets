import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { AuthService } from '@core/services/auth.service';
import { AuthFormService } from '@core/services/auth-form.service';
import { EmailValidator } from '@modules/auth/validators/email-validator';

@Component({
    selector: 'app-forgot-form',
    templateUrl: './forgot-form.component.html',
    styleUrls: ['./forgot-form.component.sass', '../../shared-styles.sass'],
})
export class ForgotFormComponent extends BaseComponent {
    recoveryCode: number;

    public forgotPasswordForm = new FormGroup(
        {
            email: new FormControl(
                '',
                [Validators.required, Validators.email],
                [EmailValidator.loginEmailValidator(this.authService)],
            ),
        },
    );

    constructor(private router: Router, private authService: AuthService, private authFormService: AuthFormService) {
        super();
    }

    resetPassword(form: FormGroup) {
        const { email } = form.value;

        this.authFormService
            .resetPassword(email)
            .subscribe(
                { next: () => this.goToSignInPage() },
            );
    }

    goToSignInPage() {
        this.router.navigate(['auth/signin']);
    }
}
