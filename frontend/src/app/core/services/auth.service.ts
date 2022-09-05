import { Injectable } from '@angular/core';
import { AngularFireAuth } from '@angular/fire/compat/auth';
import * as auth from 'firebase/auth';
import firebase from 'firebase/compat/app';
import { concatMap, defer, first, Observable } from 'rxjs';
import { map, tap } from 'rxjs/operators';

import { NotificationService } from './notification.service';
import { UserService } from './user.service';

@Injectable({
    providedIn: 'root',
})
export class AuthService {
    constructor(
        private afAuth: AngularFireAuth,
        private userService: UserService,
        private notificationService: NotificationService,
    ) {
        this.afAuth.authState.subscribe((user) => {
            if (user) {
                user.getIdToken().then((t) => localStorage.setItem('access-token', t));
                localStorage.setItem('email-verified', JSON.stringify(user.emailVerified));
            }
        });

        this.afAuth.user.subscribe((user) => {
            if (user) {
                localStorage.setItem('email-verified', JSON.stringify(user.emailVerified));
            }
        });
    }

    public signUp(email: string, password: string): Observable<firebase.auth.UserCredential> {
        return defer(() => this.afAuth.createUserWithEmailAndPassword(email, password)).pipe(
            first(),
            tap({
                next: () => this.sendEmailVerification().subscribe(),
                error: (e) => this.notificationService.showErrorMessage(e.message),
            }),
        );
    }

    public signIn(email: string, password: string): Observable<firebase.auth.UserCredential> {
        return defer(() => this.afAuth.signInWithEmailAndPassword(email, password)).pipe(
            first(),
            tap({
                next: async (userCredential) => {
                    if (userCredential.user) {
                        localStorage.setItem('access-token', await userCredential.user.getIdToken());
                    }
                },
                error: (e) => this.notificationService.showErrorMessage(e.message),
            }),
        );
    }

    public resetPassword(email: string): Observable<void> {
        return defer(() => this.afAuth.sendPasswordResetEmail(email)).pipe(
            first(),
            tap({
                error: (e) => this.notificationService.showErrorMessage(e.message),
            }),
        );
    }

    public loginWithGoogle(): Observable<firebase.auth.UserCredential> {
        return defer(() => this.loginWithProvider(new auth.GoogleAuthProvider()));
    }

    public signOut(): Observable<void> {
        return defer(() => this.afAuth.signOut()).pipe(
            first(),
            tap({
                next: () => {
                    localStorage.removeItem('user');
                    localStorage.removeItem('email-verified');
                    localStorage.removeItem('access-token');
                    localStorage.removeItem('selected-team-id');
                },
                error: (e) => this.notificationService.showErrorMessage(e.message),
            }),
        );
    }

    public isLoggedIn(): boolean {
        return JSON.parse(localStorage.getItem('email-verified')!) as boolean;
    }

    public refreshToken(): Observable<void> {
        return this.afAuth.authState.pipe(
            first((u) => !!u),
            concatMap((u) => this.setUserAccessToken(u!)),
        );
    }

    public getAccessToken() {
        return localStorage.getItem('access-token');
    }

    private loginWithProvider(
        provider: auth.GoogleAuthProvider | auth.GithubAuthProvider | auth.FacebookAuthProvider,
    ): Observable<firebase.auth.UserCredential> {
        return defer(() => this.afAuth.signInWithPopup(provider)).pipe(
            first(),
            tap({
                error: (e) => this.notificationService.showErrorMessage(e.message),
            }),
        );
    }

    private sendEmailVerification(): Observable<firebase.User | null> {
        return defer(() => this.afAuth.currentUser).pipe(
            first(),
            tap({
                next: (u) => u!.sendEmailVerification(),
                error: (e) => this.notificationService.showErrorMessage(e.message),
            }),
        );
    }

    public checkEmail(email: string): Observable<boolean> {
        return this.userService.checkExistingEmail(email).pipe(map((res) => res));
    }

    private async setUserAccessToken(user: firebase.User) {
        const token = await user.getIdToken();

        localStorage.setItem('access-token', token);
    }
}
