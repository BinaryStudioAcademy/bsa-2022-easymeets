import { Component } from '@angular/core';
import { SideMenuItem } from '@core/interfaces/sideMenu/sideMenuItem';

@Component({
    selector: 'app-team-tabs-menu',
    templateUrl: './team-tabs-menu.component.html',
    styleUrls: ['./team-tabs-menu.component.sass'],
})
export class TeamTabsMenuComponent {
    links: SideMenuItem[] = [
        { routerLink: '/settings/teams/edit/', text: 'General' },
        { routerLink: '/settings/teams/members', text: 'Members' },
        { routerLink: '/settings/teams/billing-plan', text: 'Billing Plan' },
    ];

    activeLink = this.links[0];
}
