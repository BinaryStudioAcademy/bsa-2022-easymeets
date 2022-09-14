import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
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

    constructor(private authFormService: AuthFormService) {
        super();
    }

    sendRecoveryCode() {
        // eslint-disable-next-line no-debugger
        debugger;
        this.authFormService.sendRecoveryCode('kozak.olena11@gmail.com');
    }
}
