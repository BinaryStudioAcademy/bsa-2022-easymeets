import { Component, OnInit } from '@angular/core';
import { BaseComponent } from '@core/base/base.component';
import { getUserSettingsMenuItems } from '@core/helpers/user-settings-menu-helper';
import { SideMenuGroup } from '@core/interfaces/sideMenu/sideMenuGroup';
import { ITeam } from '@core/models/ITeam';
import { SettingPageService } from '@core/services/setting-page.service';
import { TeamService } from '@core/services/team.service';

@Component({
    selector: 'app-settings-page',
    templateUrl: './settings-page.component.html',
    styleUrls: ['./settings-page.component.sass'],
})
export class SettingsPageComponent extends BaseComponent implements OnInit {
    public sideMenuGroups: SideMenuGroup[];

    private readonly teamEditBaseLink = 'teams/edit/';

    public teams: ITeam[] = [];

    public isActive: boolean;

    public isUpdateButtonActive: boolean;

    public teamsMenuGroup: SideMenuGroup = {
        header: 'Teams',
        items: [],
        showButton: true,
        buttonText: '+ New team',
        buttonRouterLink: '/settings/teams/new',
    };

    constructor(private teamService: TeamService, public settingPageService: SettingPageService) {
        super();
    }

    ngOnInit(): void {
        this.displayUserAdminTeams();
        this.initializeSideMenu();
        this.teamService.teamStateChangeEmitted$.pipe(this.untilThis).subscribe(() => this.displayUserAdminTeams());
        this.settingPageService.updateButtonActiveEvent$.pipe(this.untilThis).subscribe(isActive => {
            this.isUpdateButtonActive = isActive;
        });
    }

    private displayUserAdminTeams() {
        this.teamService
            .getCurrentUserAdminAndOwnerTeams()
            .pipe(this.untilThis)
            .subscribe((teams) => {
                this.teams = teams;
                this.teamsMenuGroup.items = teams.map((team) => ({
                    text: team.name,
                    routerLink: this.teamEditBaseLink + team.id,
                }));
            });
    }

    private initializeSideMenu() {
        this.sideMenuGroups = getUserSettingsMenuItems();
        this.sideMenuGroups.push(this.teamsMenuGroup);
    }
}
