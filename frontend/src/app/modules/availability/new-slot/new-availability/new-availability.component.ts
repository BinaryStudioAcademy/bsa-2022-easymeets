import { Component, OnInit } from '@angular/core';
import { SideMenuGroup } from '@core/interfaces/sideMenu/sideMenuGroup';

@Component({
    selector: 'app-new-availability',
    templateUrl: './new-availability.component.html',
    styleUrls: ['./new-availability.component.sass'],
})
export class NewAvailabilityComponent implements OnInit {
    public sideMenuGroups: SideMenuGroup[];

    public isActive: boolean = true;

    ngOnInit(): void {
        this.initializeSideMenu();
    }

    private initializeSideMenu() {
        this.sideMenuGroups = [{
            items: [
                { text: 'General', routerLink: 'general' },
                { text: 'Booking page', routerLink: 'event-details' },
            ],
        }];
    }
}
