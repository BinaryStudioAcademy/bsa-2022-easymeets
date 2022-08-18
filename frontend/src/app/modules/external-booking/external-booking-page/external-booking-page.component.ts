import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { IExternalBookingSideMenu } from '@core/models/IExtendBookingSideMenu';
import { LocationType } from '@core/models/locationType';
import { SpinnerService } from '@core/services/spinner.service';
import { UserService } from '@core/services/user.service';

@Component({
    selector: 'app-external-booking-page',
    templateUrl: './external-booking-page.component.html',
    styleUrls: ['./external-booking-page.component.sass'],
})
export class ExternalBookingPageComponent implements OnInit {
    public menu: IExternalBookingSideMenu = {} as IExternalBookingSideMenu;

    public selectedUserId: number = 8;

    // eslint-disable-next-line no-empty-function
    constructor(public spinnerService: SpinnerService, private userService: UserService, public router: Router) {}

    ngOnInit(): void {
        this.userService.getCurrentUserById(this.selectedUserId).subscribe((user) => {
            this.menu.user = user;
        });
    }

    public addDurationAndLocationInMenu(data: any): void {
        this.menu.duration = data.duration;
        this.menu.location = LocationType[LocationType.GoogleMeet.toString() as unknown as number];
        console.log(data.duration);
        console.log(data.location);
    }
}
