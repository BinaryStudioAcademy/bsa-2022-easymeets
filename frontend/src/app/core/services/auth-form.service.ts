import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import * as languageHelper from '@core/helpers/language-helper';
import * as timeHelper from '@core/helpers/time-format-label-mapping';
import { getDefaultTimeZone } from '@core/helpers/time-zone-helper';
import { ICreateTeamMember } from '@core/models/ICreateTeamMember';
import { IUser } from '@core/models/IUser';
import { AuthService } from '@core/services/auth.service';
import { NotificationService } from '@core/services/notification.service';
import { SpinnerService } from '@core/services/spinner.service';
import { UserService } from '@core/services/user.service';
import { DateFormat } from '@shared/enums/dateFormat';
import firebase from 'firebase/compat';
import { finalize, Observable, Subject, switchMap, tap } from 'rxjs';

import { TeamMemberService } from './team-member.service';

@Injectable({
    providedIn: 'root',
})
export class AuthFormService {
    teamId: number;

    private emitTeamMemberAddedSource = new Subject<ICreateTeamMember>();

    public teamMemberAddedEmitted$ = this.emitTeamMemberAddedSource.asObservable();

    constructor(
        private authService: AuthService,
        private spinnerService: SpinnerService,
        private userService: UserService,
        private notificationService: NotificationService,
        private router: Router,
        private teamService: TeamMemberService,
    ) {
        this.teamService.teamIdChangedEmitted$.subscribe((resp) => {
            this.teamId = resp;
        });
    }

    public signIn(email: string, password: string): Observable<IUser> {
        return this.authenticate(this.authService.signIn(email, password)).pipe(
            tap({
                next: () => {
                    if (this.teamId) {
                        const teamMember: ICreateTeamMember = { userEmail: email, teamId: this.teamId };

                        this.emitTeamMemberAddedSource.next(teamMember);
                    }
                    this.notificationService.showSuccessMessage('Authentication successful');
                },
                error: () =>
                    this.notificationService.showErrorMessage("You've entered wrong password! Please try again or reset your password."),
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

    public resetPassword(email: string): Observable<void> {
        return this.authService
            .resetPassword(email).pipe(
                tap(() =>
                    this.notificationService.showSuccessMessage(`Link for resetting password was send to this ${email} email`)),
            );
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
