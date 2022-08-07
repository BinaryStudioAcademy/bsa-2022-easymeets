import { Injectable } from '@angular/core';
import { AngularFireAuth } from '@angular/fire/compat/auth';
import * as auth from 'firebase/auth';
import firebase from 'firebase/compat';
import User = firebase.User;

@Injectable({
    providedIn: 'root',
})
export class AuthService {
    private currentUser: User | null;

    constructor(private afAuth: AngularFireAuth) {
        this.afAuth.authState.subscribe((user) => {
            this.currentUser = user;
            localStorage.setItem('user', JSON.stringify(this.currentUser));
        });
    }

    public signUp(email: string, password: string) {
        return this.afAuth
            .createUserWithEmailAndPassword(email, password)
            .then(() => this.sendEmailVerification());
    }

    public signIn(email: string, password: string) {
        return this.afAuth.signInWithEmailAndPassword(email, password);
    }

    public resetPassword(email: string) {
        return this.afAuth.sendPasswordResetEmail(email);
    }

    public loginWithGoogle() {
        return this.loginWithProvider(new auth.GoogleAuthProvider());
    }

    public signOut() {
        return this.afAuth.signOut().then(() => localStorage.removeItem('user'));
    }

    public isLoggedIn() {
        const currentUser = localStorage.getItem('user');

        if (currentUser === null) {
            return false;
        }
        const userData = JSON.parse(currentUser!) as User;

        return userData.emailVerified;
    }

    private loginWithProvider(provider: auth.GoogleAuthProvider | auth.GithubAuthProvider | auth.FacebookAuthProvider) {
        return this.afAuth.signInWithPopup(provider);
    }

    private sendEmailVerification() {
        return this.afAuth.currentUser
            .then((u) => u!.sendEmailVerification());
    }
}
