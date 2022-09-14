import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { AuthFormService } from '@core/services/auth-form.service';

@Component({
    selector: 'app-recovery-code-form',
    templateUrl: './recovery-code-form.component.html',
    styleUrls: ['./recovery-code-form.component.sass', '../../shared-styles.sass'],
})
export class RecoveryCodeFormComponent extends BaseComponent {
    constructor(private router: Router, private authFormService: AuthFormService) {
        super();
    }

    sendRessetPasswordEmail() {
        this.authFormService.sendRecoveryCode('kozak.olena11@gmail.com');
    }

    goBackToForgotPage() {
        this.router.navigate(['auth/forgot']);
    }
}
