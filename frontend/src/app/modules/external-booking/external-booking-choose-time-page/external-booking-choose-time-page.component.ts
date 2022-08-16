import { Component } from '@angular/core';
import { IUser } from '@core/models/IUser';
import { SpinnerService } from '@core/services/spinner.service';
import { UserService } from '@core/services/user.service';

@Component({
    selector: 'app-external-booking-choose-time-page',
    templateUrl: './external-booking-choose-time-page.component.html',
    styleUrls: ['./external-booking-choose-time-page.component.sass'],
})
export class ExternalBookingChooseTimeComponent {
    public selectedUser: IUser;

    public selectedUserId: number = 10;

    constructor(public spinnerService: SpinnerService, private userService: UserService) {
        this.userService.getCurrentUserById(this.selectedUserId).subscribe((user) => {
            this.selectedUser = user;
        });
    }
}
