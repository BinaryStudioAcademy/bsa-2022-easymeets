import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { SideMenuItem } from '@core/interfaces/sideMenu/sideMenuItem';

@Component({
    selector: 'app-team-tabs-menu',
    templateUrl: './team-tabs-menu.component.html',
    styleUrls: ['./team-tabs-menu.component.sass'],
})
export class TeamTabsMenuComponent extends BaseComponent implements OnInit {
    teamId: number;

    links: SideMenuItem[] = [];

    activeLink = this.links[0];

    constructor(private route: ActivatedRoute) {
        super();
    }

    ngOnInit() {
        this.route.params.subscribe((params) => (this.teamId = params['id']));
        this.links = [
            { routerLink: `/settings/teams/edit/${this.teamId}`, text: 'General' },
            { routerLink: `/settings/teams/members/${this.teamId}`, text: 'Members' },
            { routerLink: `/settings/teams/billing-plan/${this.teamId}`, text: 'Billing Plan' },
        ];
    }
}
