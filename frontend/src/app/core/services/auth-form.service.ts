import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import * as languageHelper from '@core/helpers/language-helper';
import * as timeHelper from '@core/helpers/time-format-label-mapping';
import { getDefaultTimeZone } from '@core/helpers/time-zone-helper';
import { IUser } from '@core/models/IUser';
import { AuthService } from '@core/services/auth.service';
import { NotificationService } from '@core/services/notification.service';
import { SpinnerService } from '@core/services/spinner.service';
import { UserService } from '@core/services/user.service';
import { DateFormat } from '@shared/enums/dateFormat';
import firebase from 'firebase/compat';
import { finalize, Observable, switchMap, tap } from 'rxjs';

@Injectable({
    providedIn: 'root',
})
export class AuthFormService {
    constructor(
        private authService: AuthService,
        private spinnerService: SpinnerService,
        private userService: UserService,
        private notificationService: NotificationService,
        private router: Router,
        // eslint-disable-next-line no-empty-function
    ) {}

    public signIn(email: string, password: string): Observable<IUser> {
        return this.authenticate(this.authService.signIn(email, password)).pipe(
            tap({
                next: () => this.notificationService.showSuccessMessage('Authentication successful'),
                error: (e) => this.notificationService.showErrorMessage(e),
            }),
        );
    }

    public signUp(email: string, password: string, userName: string): Observable<IUser> {
        return this.authenticate(this.authService.signUp(email, password), userName).pipe(
            tap({ next: () => this.notificationService.showInfoMessage('Verification email has been sent') }),
        );
    }

    public onSignInWithGoogle(): Observable<IUser> {
        return this.authenticate(this.authService.loginWithGoogle()).pipe(
            tap({ next: () => this.notificationService.showSuccessMessage('Authentication successful') }),
        );
    }

    public resetPassword(email: string) {
        this.authService
            .resetPassword(email)
            .subscribe(() => {
                this.notificationService.showSuccessMessage(`Link for resseting password was send to this ${email} email`);
            });
    }

    private authenticate(authMethod: Observable<firebase.auth.UserCredential>, userName?: string): Observable<IUser> {
        this.spinnerService.show();

        return authMethod.pipe(
            finalize(() => this.spinnerService.hide()),
            switchMap((userCredential) => this.createUser(userCredential, userName)),
        );
    }

    private createUser(resp: firebase.auth.UserCredential, userName: string = 'UserName'): Observable<IUser> {
        return this.userService
            .createUser({
                uid: resp.user?.uid,
                userName: resp.user?.displayName ?? userName,
                email: resp.user?.email ?? '',
                personalUrl: resp.user?.email?.substring(0, resp.user?.email.indexOf('@')).replace('.', '-') ?? '',
                image: resp.user?.photoURL ?? undefined,
                language: languageHelper.getLanguage(),
                timeFormat: timeHelper.getTimeFormat(),
                dateFormat: DateFormat.MonthDayYear,
                phone: resp.user?.phoneNumber ?? undefined,
                timeZone: getDefaultTimeZone(),
            })
            .pipe(
                tap(() => {
                    this.router.navigateByUrl('availability');
                }),
            );
    }
}
