import { Component, Input } from '@angular/core';
import { IExtendBookingSideMenu } from '@core/models/IExtendBookingSideMenu';
import { IUser } from '@core/models/IUser';
import { SpinnerService } from '@core/services/spinner.service';
import { UserService } from '@core/services/user.service';

@Component({
    selector: 'app-external-booking-page',
    templateUrl: './external-booking-page.component.html',
    styleUrls: ['./external-booking-page.component.sass'],
})
export class ExternalBookingPageComponent {
    @Input() menu: IExtendBookingSideMenu;

    public selectedUser: IUser;

    public selectedUserId: number = 10;

    constructor(public spinnerService: SpinnerService, private userService: UserService) {
        this.userService.getCurrentUserById(this.selectedUserId).subscribe((user) => {
            this.selectedUser = user;
        });
    }
}
