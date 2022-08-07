import { Injectable } from '@angular/core';
import { AngularFireAuth } from '@angular/fire/compat/auth';
import firebase from 'firebase/compat';
import User = firebase.User;

@Injectable({
    providedIn: 'root',
})
export class AuthServiceService {
    private userData: User | null;

    constructor(private afAuth: AngularFireAuth) {
        this.afAuth.authState.subscribe((user) => {
            this.userData = user;
            localStorage.setItem('user', JSON.stringify(this.userData));
        });
    }
}
