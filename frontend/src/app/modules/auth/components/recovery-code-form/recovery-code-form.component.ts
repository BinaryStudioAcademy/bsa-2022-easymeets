import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';

@Component({
    selector: 'app-recovery-code-form',
    templateUrl: './recovery-code-form.component.html',
    styleUrls: ['./recovery-code-form.component.sass', '../../shared-styles.sass'],
})
export class RecoveryCodeFormComponent extends BaseComponent {
    constructor(private router: Router) {
        super();
    }

    goBackToForgotPage() {
        this.router.navigate(['auth/forgot']);
    }
}
