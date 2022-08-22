import { Component, OnInit } from '@angular/core';
import { getUserSettingsMenuItems } from '@core/helpers/user-settings-menu-helper';
import { SideMenuGroup } from '@core/interfaces/sideMenu/sideMenuGroup';

@Component({
    selector: 'app-settings-page',
    templateUrl: './settings-page.component.html',
    styleUrls: ['./settings-page.component.sass'],
})
export class SettingsPageComponent implements OnInit {
    public sideMenuGroups: SideMenuGroup[];

    public isActive: boolean = true;

    ngOnInit(): void {
        this.initializeSideMenu();
    }

    private initializeSideMenu() {
        this.sideMenuGroups = getUserSettingsMenuItems();
    }
}
