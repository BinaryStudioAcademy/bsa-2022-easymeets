import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { getNewAvailabilityMenu } from '@core/helpers/new-availability-menu-helper';
import { Router } from "@angular/router";
import { SideMenuGroupTabs } from "@core/interfaces/sideMenu/tabs/sideMenuGroupTabs";

@Component({
    selector: 'app-new-availability',
    templateUrl: './new-availability.component.html',
    styleUrls: ['./new-availability.component.sass'],
})
export class NewAvailabilityComponent implements OnInit {
    @Output() saveChangesClick: EventEmitter<void> = new EventEmitter();

    @Output() cancelClick: EventEmitter<void> = new EventEmitter();

    @Output() deleteClick: EventEmitter<void> = new EventEmitter();

    public sideMenuGroups: SideMenuGroupTabs[];

    public isActive: boolean = true;

    public index: number = 0;

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
