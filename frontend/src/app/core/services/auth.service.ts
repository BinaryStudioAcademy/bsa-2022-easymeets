import { Injectable } from '@angular/core';
import { AngularFireAuth } from '@angular/fire/compat/auth';
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

    public sendEmailVerification() {
        return this.afAuth.currentUser
            .then((u) => u!.sendEmailVerification());
    }
}
