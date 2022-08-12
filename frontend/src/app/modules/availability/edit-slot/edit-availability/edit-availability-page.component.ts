import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { getNewAvailabilityMenu } from '@core/helpers/new-availability-menu-helper';
import { SideMenuGroup } from '@core/interfaces/sideMenu/sideMenuGroup';
import { Subscription } from 'rxjs';

@Component({
    selector: 'app-edit-availability-page',
    templateUrl: './edit-availability-page.component.html',
    styleUrls: ['./edit-availability-page.component.sass'],
})
export class EditAvailabilityPageComponent implements OnInit {
    public sideMenuGroups: SideMenuGroup[];

    public isActive: boolean = true;

    private id: number | undefined;

    private subscription: Subscription;

    constructor(private router: Router, private activateRoute: ActivatedRoute) {
        this.subscription = activateRoute.params.subscribe(params => {
            this.id = params['id'];
        });
    }

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
