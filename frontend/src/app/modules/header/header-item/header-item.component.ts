import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from '@core/services/auth.service';

@Component({
    selector: 'app-header-item',
    templateUrl: './header-item.component.html',
    styleUrls: ['./header-item.component.sass'],
})
export class HeaderItemComponent {
    // eslint-disable-next-line no-empty-function
    constructor(private authService: AuthService, private router: Router) {}

    public logout() {
        return this.authService.signOut().then(() => {
            localStorage.removeItem('user');
            this.router.navigateByUrl('auth');
        });
    }
}
