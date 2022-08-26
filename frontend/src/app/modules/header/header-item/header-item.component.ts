import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { ILocalUser } from '@core/models/IUser';
import { AuthService } from '@core/services/auth.service';
import { UserService } from '@core/services/user.service';

@Component({
    selector: 'app-header-item',
    templateUrl: './header-item.component.html',
    styleUrls: ['./header-item.component.sass'],
})
export class HeaderItemComponent extends BaseComponent implements OnInit {
    public currentUser: ILocalUser;

    constructor(private authService: AuthService, private userService: UserService, private router: Router) {
        super();
    }

    ngOnInit(): void {
        this.currentUser = this.userService.getUserFromStorage();
    }

    public navLinks = [
        { path: '../availability', label: 'Availability' },
        { path: '../bookings', label: 'Bookings' },
    ];

    public activeTab = this.navLinks[0].label;

    public logout() {
        return this.authService.signOut().then(() => {
            this.router.navigateByUrl('auth');
        });
    }
}
