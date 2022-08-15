import { Component, OnInit } from '@angular/core';
import { getNewAvailabilityMenu } from '@core/helpers/new-availability-menu-helper';
import { SideMenuGroup } from '@core/interfaces/sideMenu/sideMenuGroup';

@Component({
    selector: 'app-new-availability',
    templateUrl: './new-availability.component.html',
    styleUrls: ['./new-availability.component.sass'],
})
export class NewAvailabilityComponent implements OnInit {
    public sideMenuGroups: SideMenuGroup[];

    public isActive: boolean = true;

    public index: number = 0;

    ngOnInit(): void {
        this.initializeSideMenu();
    }

    private initializeSideMenu() {
        this.sideMenuGroups = getNewAvailabilityMenu();
    }
}
