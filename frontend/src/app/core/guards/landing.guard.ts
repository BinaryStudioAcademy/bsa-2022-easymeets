import { Injectable } from '@angular/core';
import { CanActivate, Router } from '@angular/router';
import { AuthService } from '@core/services/auth.service';

@Injectable({
    providedIn: 'root',
})
export class LandingGuard implements CanActivate {
    // eslint-disable-next-line no-empty-function
    constructor(private authService: AuthService, private router: Router) {}

    canActivate() {
        return !this.authService.isLoggedIn() ? true : this.router.parseUrl('/availability');
    }
}
