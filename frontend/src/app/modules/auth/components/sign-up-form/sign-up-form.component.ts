import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthService } from '@core/services/auth.service';
import { NotificationService } from '@core/services/notification.service';
import { UserService } from '@core/services/user.service';
import { PasswordsErrorStateMatcher } from '@modules/auth/validators/passwordsErrorStateMatcher';
import { userNameRegex } from '@shared/constants/model-validation';
import { DateFormat } from '@shared/enums/dateFormat';
import { Language } from '@shared/enums/language';
import { TimeFormat } from '@shared/enums/timeFormat';
import firebase from 'firebase/compat';
import { Subject, takeUntil } from 'rxjs';

@Component({
    selector: 'app-sign-up-form',
    templateUrl: './sign-up-form.component.html',
    styleUrls: ['./sign-up-form.component.sass', '../../shared-styles.sass'],
})
export class SignUpFormComponent {
    public matcher = new PasswordsErrorStateMatcher();

    public hidePassword = true;

    private unsubscribe$ = new Subject<void>();

    public signUpForm = new FormGroup({
        email: new FormControl('', { validators: [Validators.required, Validators.email], updateOn: 'submit' }),
        name: new FormControl('', {
            validators: [
                Validators.required,
                Validators.minLength(3),
                Validators.maxLength(50),
                Validators.pattern(userNameRegex),
            ],
            updateOn: 'submit',
        }),
        password: new FormControl('', {
            validators: [Validators.required, Validators.minLength(8), Validators.maxLength(30)],
            updateOn: 'blur',
        }),
        confirmPassword: new FormControl('', { updateOn: 'blur' }),
    });

    constructor(
        private authService: AuthService,
        private router: Router,
        private userService: UserService,
        private notifications: NotificationService,
        // eslint-disable-next-line no-empty-function
    ) { }

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
                    dateFormat: DateFormat.Hyphen,
                    phone: resp.user?.phoneNumber ?? undefined,
                    timeZone: new Date().getTimezoneOffset(),
                })
                .pipe(takeUntil(this.unsubscribe$))
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

    private getLanguage(): Language {
        const userLanguageBrowser =
            navigator.languages && navigator.languages.length
                ? navigator.languages[0]
                : navigator.language;

        let userLanguage: Language;

        if (userLanguageBrowser.includes('en')) {
            userLanguage = Language.Eng;
        } else if (userLanguageBrowser.includes('uk')) {
            userLanguage = Language.Ukr;
        } else if (userLanguageBrowser.includes('pl')) {
            userLanguage = Language.Pl;
        } else if (userLanguageBrowser.includes('fr')) {
            userLanguage = Language.Fr;
        } else if (userLanguageBrowser.includes('it')) {
            userLanguage = Language.It;
        } else {
            userLanguage = Language.Eng;
        }

        return userLanguage;
    }

    private getTimeFormat() {
        return new Intl.DateTimeFormat().resolvedOptions().hour12
            ? TimeFormat.TwelveHour
            : TimeFormat.TwentyFourHour;
    }
}
