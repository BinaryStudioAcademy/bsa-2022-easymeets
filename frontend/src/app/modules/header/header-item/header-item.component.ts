import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { ITeam } from '@core/models/ITeam';
import { ILocalUser } from '@core/models/IUser';
import { AuthService } from '@core/services/auth.service';
import { TeamService } from '@core/services/team.service';
import { UserService } from '@core/services/user.service';
import { combineLatest } from 'rxjs';

@Component({
    selector: 'app-header-item',
    templateUrl: './header-item.component.html',
    styleUrls: ['./header-item.component.sass'],
})
export class HeaderItemComponent extends BaseComponent implements OnInit {
    public teams: ITeam[] = [];

    public currentUser: ILocalUser;

    public currentTeam?: ITeam;

    constructor(
        private authService: AuthService,
        private router: Router,
        private teamService: TeamService,
        private userService: UserService,
    ) {
        super();
    }

    ngOnInit(): void {
        this.currentUser = this.userService.getUserFromStorage();
        this.teamService.currentTeamEmitted$
            .pipe(this.untilThis)
            .subscribe(currentTeamId => {
                this.teamService.getCurrentUserTeams()
                    .subscribe(teams => {
                        this.teams = teams;
                        this.currentTeam = this.teams.find(team => team.id === currentTeamId);
                    });
            });

        this.teamService.teamCreationEmitted$
            .subscribe(() => {
                this.teamService.getCurrentUserTeams()
                    .pipe(this.untilThis)
                    .subscribe(result => {
                        this.teams = result;
                    });
            });

        this.teamService.teamDeletionEmitted$
            .subscribe((deletedTeamId: number) => {
                this.teamService.getCurrentUserTeams()
                    .pipe(this.untilThis)
                    .subscribe(result => {
                        this.teams = result;
                        if (this.currentTeam?.id === deletedTeamId) {
                            this.teamService.emitCurrentTeamChange(this.teams.length ? this.teams[0].id : undefined);
                        }
                    });
            });
    }

    public navLinks = [
        { path: '../availability', label: 'Availability' },
        { path: '../bookings', label: 'Bookings' },
    ];

    public activeTab = this.navLinks[0].label;

    public logout() {
        return this.authService.signOut().then(() => {
            this.router.navigateByUrl('auth');
        });
    }

    public changeTeam(teamId: number) {
        this.teamService.emitCurrentTeamChange(teamId);
    }

    public navigateToTeam() {
        this.router.navigateByUrl(
            this.currentTeam
                ? `/settings/teams/edit/${this.currentTeam?.id}`
                : '/settings/teams/new',
        );
    }
}
