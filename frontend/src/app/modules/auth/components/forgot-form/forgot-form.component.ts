import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { AuthFormService } from '@core/services/auth-form.service';

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
            ),
        },
    );

    constructor(private authFormService: AuthFormService, private router: Router) {
        super();
    }

    sendRecoveryCode() {
        this.goToRecoveryCodeComponent();
        //this.authFormService.sendRecoveryCode('kozak.olena11@gmail.com');
    }

    goToRecoveryCodeComponent() {
        this.router.navigate(['auth/recovery-code']);
    }
}
