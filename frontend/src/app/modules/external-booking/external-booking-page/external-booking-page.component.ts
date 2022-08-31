import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { LocationTypeToLabelMapping } from '@core/helpers/location-type-label-mapping';
import { IAvailabilitySlotMember } from '@core/models/IAvailabilitySlotMember';
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
        if (this.isTeamBooking()) {
            this.menu = {
                ...this.menu,
                team: {
                    id: 1,
                    image: '',
                    name: 'My Default Team',
                    pageLink: '',
                    timeZoneValue: 0,
                    timeZoneName: 'Europe/Kiev (+03:00)',
                    description: '',
                },
                duration: 30,
                location: LocationType.GoogleMeet,
            };
        }
        this.userService.getCurrentUser().subscribe((user) => {
            this.menu = {
                ...this.menu,
                user,
            };
        });
    }

    public addDurationAndLocationInMenu(data: { duration: number; location: LocationType }): void {
        this.menu = {
            ...this.menu,
            duration: data.duration,
            location: data.location,
        };
    }

    public addTimeAndDateInMenu(data: { date: Date; timeFinish: Date }): void {
        this.menu = {
            ...this.menu,
            date: data.date,
            timeFinish: data.timeFinish,
        };
    }

    public addMembersInMenu(selectedMembers: IAvailabilitySlotMember[]) {
        this.menu = {
            ...this.menu,
            teamSlotMembers: selectedMembers,
        };
    }

    isBookingChooseTimeRoute(): boolean {
        return this.router.url.includes('/external-booking/choose-time');
    }

    isConfirmBookingRoute(): boolean {
        return this.router.url.includes('/external-booking/confirm-booking');
    }

    isTeamBooking(): boolean {
        return this.router.url.includes('/team/');
    }
}
