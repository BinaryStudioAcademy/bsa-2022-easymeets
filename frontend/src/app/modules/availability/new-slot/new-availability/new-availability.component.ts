import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { getNewAvailabilityMenu } from '@core/helpers/new-availability-menu-helper';
import { Router } from "@angular/router";
import { SideMenuGroupTabs } from "@core/interfaces/sideMenu/tabs/sideMenuGroupTabs";
import { IAvailabilitySlot } from "@core/models/IAvailiabilitySlot";

@Component({
    selector: 'app-new-availability',
    templateUrl: './new-availability.component.html',
    styleUrls: ['./new-availability.component.sass'],
})
export class NewAvailabilityComponent implements OnInit {
    @Input() showDeleteBlock: boolean = true;

    @Input() public slot?: IAvailabilitySlot;

    @Input() public title: string;

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
        this.isActive =this.slot?.isEnabled ?? true;
    }

    private initializeSideMenu() {
        this.sideMenuGroups = getNewAvailabilityMenu();
    }

    public goToPage(pageName: string) {
        this.router.navigate([`${pageName}`]);
    }
}
