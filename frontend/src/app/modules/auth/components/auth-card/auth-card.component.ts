import { Component } from '@angular/core';

@Component({
    selector: 'app-auth-card',
    templateUrl: './auth-card.component.html',
    styleUrls: ['./auth-card.component.sass'],
})
export class AuthCardComponent {
    public navLinks = [
        { path: 'signin', label: 'Sign In' },
        { path: 'signup', label: 'Registration' },
        //{ path: 'forgot', label: 'Forgot' },
        { path: 'recovery-code', label: 'Recovery' },
    ];

    public activeTab = this.navLinks[0].label;
}
