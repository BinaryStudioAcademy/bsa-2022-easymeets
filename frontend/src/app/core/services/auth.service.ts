import { Injectable } from '@angular/core';
import { AngularFireAuth } from '@angular/fire/compat/auth';
import * as auth from 'firebase/auth';
import firebase from 'firebase/compat';

import { NotificationService } from './notification.service';
import User = firebase.User;

@Injectable({
    providedIn: 'root',
})
export class AuthService {
    private currentUser: User | null;

    constructor(private afAuth: AngularFireAuth, private notificationService: NotificationService) {
        this.afAuth.authState.subscribe((user) => {
            this.currentUser = user;

            if (this.currentUser) {
                localStorage.setItem('user', JSON.stringify(this.currentUser));
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
        const currentUser = localStorage.getItem('user');

        if (!currentUser) {
            return false;
        }
        const userData = JSON.parse(currentUser!) as User;

        return userData.emailVerified;
    }

    public getCurrentToken() {
        return this.currentUser?.getIdToken();
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
}
