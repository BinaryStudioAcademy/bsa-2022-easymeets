import { Component } from '@angular/core';
import { IUser } from '@core/models/IUser';
import { SpinnerService } from '@core/services/spinner.service';

@Component({
    selector: 'app-external-booking-page',
    templateUrl: './external-booking-page.component.html',
    styleUrls: ['./external-booking-page.component.sass'],
})
export class ExternalBookingPageComponent {
    public selectedUser: IUser;

    // eslint-disable-next-line no-empty-function
    constructor(public spinnerService: SpinnerService) {
        const user = localStorage.getItem('user');

        this.selectedUser = JSON.parse(user!) as IUser;
    }
}
