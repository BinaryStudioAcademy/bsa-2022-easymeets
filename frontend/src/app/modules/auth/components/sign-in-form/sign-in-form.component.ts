import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { transformTextLanguageToEnum } from '@core/helpers/language-helper';
import { getDefaultTimeZone } from '@core/helpers/time-zone-helper';
import { AuthService } from '@core/services/auth.service';
import { NotificationService } from '@core/services/notification.service';
import { SpinnerService } from '@core/services/spinner.service';
import { UserService } from '@core/services/user.service';
import { EmailValidator } from '@modules/auth/validators/email-validator';
import { DateFormat } from '@shared/enums/dateFormat';
import { Language } from '@shared/enums/language';
import { TimeFormat } from '@shared/enums/timeFormat';
import firebase from 'firebase/compat';

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

    constructor(
        private authService: AuthService,
        private userService: UserService,
        private router: Router,
        private spinnerService: SpinnerService,
        private notifications: NotificationService,
    ) {
        super();
    }

    private setCredentialsIncorrect() {
        this.signInForm.get('password')?.setErrors({ incorrectCredentials: true });
    }

    private handleAuthenticationResponse(resp: firebase.auth.UserCredential | void): void {
        if (resp) {
            this.userService
                .createUser({
                    uid: resp.user?.uid,
                    userName: resp.user?.displayName ?? this.signInForm.get('name')?.value ?? '',
                    email: resp.user?.email ?? '',
                    personalUrl: resp.user?.email?.substring(0, resp.user?.email.indexOf('@')).replace('.', '-') ?? '',
                    image: resp.user?.photoURL ?? undefined,
                    language: this.getLanguage(),
                    timeFormat: this.getTimeFormat(),
                    dateFormat: DateFormat.MonthDayYear,
                    phone: resp.user?.phoneNumber ?? undefined,
                    timeZone: getDefaultTimeZone(),
                })
                .pipe(this.untilThis)
                .subscribe(() => {
                    this.notifications.showSuccessMessage('You are successfully registered');
                    this.router.navigateByUrl('availability');
                });
        } else {
            this.setCredentialsIncorrect();
        }
    }

    public onSignIn(): void {
        if (this.signInForm.valid) {
            this.spinnerService.show();
            this.authService
                .signIn(this.signInForm.value.email!, this.signInForm.value.password!)
                .then((resp) => this.handleAuthenticationResponse(resp))
                .finally(() => this.spinnerService.hide());
        }
    }

    public onSignInWithGoogle(): void {
        this.spinnerService.show();
        this.authService
            .loginWithGoogle()
            .then((resp) => this.handleAuthenticationResponse(resp))
            .finally(() => this.spinnerService.hide());
    }

    private getLanguage(): Language {
        const userLanguageBrowser =
            navigator.languages && navigator.languages.length ? navigator.languages[0] : navigator.language;

        return transformTextLanguageToEnum(userLanguageBrowser);
    }

    private getTimeFormat() {
        return new Intl.DateTimeFormat().resolvedOptions().hour12 ? TimeFormat.TwelveHour : TimeFormat.TwentyFourHour;
    }
}
