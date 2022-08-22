import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { LocationTypeToLabelMapping } from '@core/helpers/location-type-label-mapping';
import { IExternalBookingSideMenu } from '@core/models/IExtendBookingSideMenu';
import { LocationType } from '@core/models/locationType';
import { SpinnerService } from '@core/services/spinner.service';
import { UserService } from '@core/services/user.service';

@Component({
    selector: 'app-external-booking-page',
    templateUrl: './external-booking-page.component.html',
    styleUrls: ['./external-booking-page.component.sass'],
})
export class ExternalBookingPageComponent extends BaseComponent implements OnInit {
    public menu: IExternalBookingSideMenu = {} as IExternalBookingSideMenu;

    public LocationTypeToLabelMapping = LocationTypeToLabelMapping;

    public LocationType = LocationType;

    constructor(public spinnerService: SpinnerService, private userService: UserService, public router: Router) {
        super();
    }

    ngOnInit(): void {
        this.userService.getCurrentUser().subscribe((user) => {
            this.menu = {
                ...this.menu,
                user,
            };
        });
    }

    public addDurationAndLocationInMenu(data: any): void {
        this.menu = {
            ...this.menu,
            duration: data.duration,
            location: data.location,
        };
    }

    isBookingChooseTimeRoute(): boolean {
        return this.router.url.includes('/external-booking/choose-time');
    }
}
