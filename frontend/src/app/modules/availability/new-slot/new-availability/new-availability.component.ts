import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { getNewAvailabilityMenu } from '@core/helpers/new-availability-menu-helper';
import { SideMenuGroup } from '@core/interfaces/sideMenu/sideMenuGroup';

@Component({
    selector: 'app-new-availability',
    templateUrl: './new-availability.component.html',
    styleUrls: ['./new-availability.component.sass'],
})
export class NewAvailabilityComponent implements OnInit {
    @Output() saveChangesClick: EventEmitter<void> = new EventEmitter();

    @Output() cancelClick: EventEmitter<void> = new EventEmitter();

    @Output() deleteClick: EventEmitter<void> = new EventEmitter();

    public sideMenuGroups: SideMenuGroup[];

    public isActive: boolean = true;

    ngOnInit(): void {
        this.initializeSideMenu();
    }

    private initializeSideMenu() {
        this.sideMenuGroups = getNewAvailabilityMenu();
    }
}
