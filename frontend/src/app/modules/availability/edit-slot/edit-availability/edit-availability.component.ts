import { Component, OnInit } from '@angular/core';
import { getNewAvailabilityMenu } from '@core/helpers/new-availability-menu-helper';
import { SideMenuGroup } from '@core/interfaces/sideMenu/sideMenuGroup';
import { Router } from '@angular/router';

@Component({
    selector: 'app-new-availability',
    templateUrl: './edit-availability.component.html',
    styleUrls: ['./edit-availability.component.sass'],
})
export class EditAvailabilityComponent implements OnInit {
    public sideMenuGroups: SideMenuGroup[];

    public isActive: boolean = true;

    // eslint-disable-next-line no-empty-function
    constructor(private router: Router) { }

    ngOnInit(): void {
        this.initializeSideMenu();
    }

    private initializeSideMenu() {
        this.sideMenuGroups = getNewAvailabilityMenu();
    }

    public goToPage(pageName: string) {
        this.router.navigate([`${pageName}`]);
    }
}
