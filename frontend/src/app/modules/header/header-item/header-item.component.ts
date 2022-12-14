import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { TeamStateChangeActionEnum } from '@core/enums/team-state-change-action.enum';
import { ITeam } from '@core/models/ITeam';
import { AuthService } from '@core/services/auth.service';
import { TeamService } from '@core/services/team.service';
import { UserService } from '@core/services/user.service';

@Component({
    selector: 'app-header-item',
    templateUrl: './header-item.component.html',
    styleUrls: ['./header-item.component.sass'],
})
export class HeaderItemComponent extends BaseComponent implements OnInit {
    public teams: ITeam[] = [];

    public currentUserImage?: string;

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
        this.userService.userChangedEvent$.pipe(this.untilThis).subscribe({
            next: (user) => {
                this.currentUserImage = user?.image;
            },
        });

        this.teamService.currentTeamEmitted$.pipe(this.untilThis).subscribe((currentTeamId) => {
            this.teamService
                .getCurrentUserTeams()
                .pipe(this.untilThis)
                .subscribe((teams) => {
                    this.teams = teams;
                    this.defineCurrentTeam(teams, currentTeamId);
                });
        });

        this.teamService.teamStateChangeEmitted$.subscribe(
            (teamChange: { teamId: number; action: TeamStateChangeActionEnum }) => {
                this.teamService
                    .getCurrentUserTeams()
                    .pipe(this.untilThis)
                    .subscribe((result) => {
                        this.teams = result;
                        if (
                            teamChange.action === TeamStateChangeActionEnum.Deleted &&
                            this.currentTeam?.id === teamChange.teamId
                        ) {
                            this.teamService.emitCurrentTeamChange(this.teams.length ? this.teams[0].id : undefined);
                        }
                    });
            },
        );
    }

    public navLinks = [
        { path: '/availability', label: 'Availability' },
        { path: '/bookings', label: 'Bookings' },
    ];

    public activeTab = this.navLinks[0].label;

    public logout() {
        return this.authService.signOut().subscribe(() => this.router.navigateByUrl('auth'));
    }

    public changeTeam(teamId: number) {
        this.teamService.emitCurrentTeamChange(teamId);
    }

    public navigateToTeam() {
        this.router.navigateByUrl(
            this.currentTeam ? `/settings/teams/edit/${this.currentTeam?.id}` : '/settings/teams/new',
        );
    }

    private defineCurrentTeam(teams: ITeam[], currentTeamId: number | undefined) {
        if (!currentTeamId && teams.length) {
            this.teamService.emitCurrentTeamChange(this.teamService.getSelectedTeamId() || teams[0].id);
        } else {
            this.currentTeam = this.teams.find((team) => team.id === currentTeamId);
        }
    }
}
