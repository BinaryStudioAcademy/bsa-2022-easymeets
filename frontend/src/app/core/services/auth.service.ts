import { Injectable } from '@angular/core';
import { AngularFireAuth } from '@angular/fire/compat/auth';
import * as auth from 'firebase/auth';
import firebase from 'firebase/compat/app';
import { map, Observable } from 'rxjs';

import { NotificationService } from './notification.service';
import { UserService } from './user.service';
import User = firebase.User;

@Injectable({
    providedIn: 'root',
})
export class AuthService {
    private currentUser: User | null;

    constructor(
        private afAuth: AngularFireAuth,
        private userService: UserService,
        private notificationService: NotificationService,
    ) {
        this.afAuth.authState.subscribe((user) => {
            this.currentUser = user;
            if (this.currentUser) {
                this.currentUser.getIdToken().then(t => localStorage.setItem('access-token', t));
                localStorage.setItem('email-verified', JSON.stringify(this.currentUser.emailVerified));
            }
        });

        this.afAuth.user.subscribe(user => {
            if (user) {
                localStorage.setItem('email-verified', JSON.stringify(user.emailVerified));
            }
        });
    }

    public signUp(email: string, password: string) {
        return this.afAuth
            .createUserWithEmailAndPassword(email, password)
            .then((credentials) => {
                this.sendEmailVerification();

                return credentials;
            })
            .catch((error) => this.notificationService.showErrorMessage(error.message));
    }

    public signIn(email: string, password: string) {
        return this.afAuth
            .signInWithEmailAndPassword(email, password)
            .then(async userCredential => {
                if (userCredential.user) {
                    localStorage.setItem('access-token', await userCredential.user.getIdToken());
                }

                return userCredential;
            })
            .catch((error) => this.notificationService.showErrorMessage(error.message));
    }

    public resetPassword(email: string) {
        return this.afAuth
            .sendPasswordResetEmail(email)
            .catch((error) => this.notificationService.showErrorMessage(error.message));
    }

    public loginWithGoogle() {
        return this.loginWithProvider(new auth.GoogleAuthProvider());
    }

    public signOut() {
        return this.afAuth
            .signOut()
            .then(() => localStorage.removeItem('user'))
            .catch((error) => this.notificationService.showErrorMessage(error.message));
    }

    public isLoggedIn() {
        return JSON.parse(localStorage.getItem('email-verified')!) as boolean;
    }

    public refreshToken() {
        return firebase.auth().currentUser?.getIdToken().then(t => localStorage.setItem('access-token', t));
    }

    public getAccessToken() {
        return localStorage.getItem('access-token');
    }

    private loginWithProvider(provider: auth.GoogleAuthProvider | auth.GithubAuthProvider | auth.FacebookAuthProvider) {
        return this.afAuth
            .signInWithPopup(provider)
            .catch((error) => this.notificationService.showErrorMessage(error.message));
    }

    private sendEmailVerification() {
        return this.afAuth.currentUser
            .then((u) => u!.sendEmailVerification())
            .catch((error) => this.notificationService.showErrorMessage(error.message));
    }

    public checkEmail(email: string): Observable<boolean> {
        return this.userService.checkExistingEmail(email).pipe(map((res) => res));
    }
}
