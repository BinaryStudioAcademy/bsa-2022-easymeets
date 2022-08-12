import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { getNewAvailabilityMenu } from '@core/helpers/new-availability-menu-helper';
import { SideMenuGroup } from '@core/interfaces/sideMenu/sideMenuGroup';

@Component({
    selector: 'app-edit-availability-page',
    templateUrl: './edit-availability-page.component.html',
    styleUrls: ['./edit-availability-page.component.sass'],
})
export class EditAvailabilityPageComponent implements OnInit {
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
