import { Component } from '@angular/core';
import { ILocalUser } from '@core/models/IUser';
import { SpinnerService } from '@core/services/spinner.service';
import { UserService } from '@core/services/user.service';

@Component({
    selector: 'app-external-booking-page',
    templateUrl: './external-booking-page.component.html',
    styleUrls: ['./external-booking-page.component.sass'],
})
export class ExternalBookingPageComponent {
    public selectedUser: ILocalUser;

    // eslint-disable-next-line no-empty-function
    constructor(public spinnerService: SpinnerService, private userService: UserService) {
        this.selectedUser = this.userService.getUserFromStorage();
    }
}
