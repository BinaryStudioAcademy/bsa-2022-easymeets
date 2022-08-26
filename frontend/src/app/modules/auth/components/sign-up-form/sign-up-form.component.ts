import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { transformTextLanguageToEnum } from '@core/helpers/language-helper';
import { AuthService } from '@core/services/auth.service';
import { NotificationService } from '@core/services/notification.service';
import { UserService } from '@core/services/user.service';
import { EmailValidator } from '@modules/auth/validators/email-validator';
import { PasswordsErrorStateMatcher } from '@modules/auth/validators/passwordsErrorStateMatcher';
import { userNameRegex } from '@shared/constants/model-validation';
import { DateFormat } from '@shared/enums/dateFormat';
import { Language } from '@shared/enums/language';
import { TimeFormat } from '@shared/enums/timeFormat';
import firebase from 'firebase/compat';

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
        confirmPassword: new FormControl('', { updateOn: 'change' }),
    });

    constructor(
        private authService: AuthService,
        private router: Router,
        private userService: UserService,
        private notifications: NotificationService,
    ) {
        super();
    }

    private setCredentialsIncorrect() {
        this.signUpForm.get('email')?.setErrors({ incorrectCredentials: true });
        this.signUpForm.get('name')?.setErrors({ incorrectCredentials: true });
        this.signUpForm.get('password')?.setErrors({ incorrectCredentials: true });
    }

    private handleAuthenticationResponce(resp: firebase.auth.UserCredential | void): void {
        if (resp) {
            this.userService
                .createUser({
                    uid: resp.user?.uid,
                    userName: resp.user?.displayName ?? this.signUpForm.get('name')?.value ?? '',
                    email: resp.user?.email ?? '',
                    image: resp.user?.photoURL ?? undefined,
                    language: this.getLanguage(),
                    timeFormat: this.getTimeFormat(),
                    dateFormat: DateFormat.MonthDayYear,
                    phone: resp.user?.phoneNumber ?? undefined,
                    timeZone: new Date().getTimezoneOffset(),
                })
                .pipe(this.untilThis)
                .subscribe(
                    () => {
                        this.notifications.showSuccessMessage('You are successfully registered');
                        this.router.navigateByUrl('availability');
                    },
                    (error) => {
                        this.notifications.showErrorMessage(error);
                    },
                );
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

    public getEmailErrorMessage(): string {
        if (this.signUpForm.controls.email.hasError('userAlreadyExists')) {
            return 'An account already exists with this email address';
        }

        return this.signUpForm.controls.email.invalid ? 'Email format is invalid' : '';
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
