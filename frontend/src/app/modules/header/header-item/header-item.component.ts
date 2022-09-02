import { Component, EventEmitter, OnDestroy, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { TeamStateChangeActionEnum } from '@core/enums/team-state-change-action.enum';
import { ITeam } from '@core/models/ITeam';
import { ILocalUser } from '@core/models/IUser';
import { AuthService } from '@core/services/auth.service';
import { ConfirmationWindowService } from '@core/services/confirmation-window.service';
import { TeamService } from '@core/services/team.service';
import { UserService } from '@core/services/user.service';
import { leavePageMessage } from '@shared/constants/shared-messages';
import { Subscription } from 'rxjs';

@Component({
    selector: 'app-header-item',
    templateUrl: './header-item.component.html',
    styleUrls: ['./header-item.component.sass'],
})
export class HeaderItemComponent extends BaseComponent implements OnInit, OnDestroy {
    public teams: ITeam[] = [];

    public currentUser: ILocalUser;

    public currentTeam?: ITeam;

    private navigateEventEmitter = new EventEmitter<void>();

    private navigateEventSubscription: Subscription;

    constructor(
        private authService: AuthService,
        private router: Router,
        private teamService: TeamService,
        private userService: UserService,
        private confirmWindowService: ConfirmationWindowService,
    ) {
        super();
        this.navigateEventSubscription = this.navigateEventEmitter.subscribe(() => this.navigateToTab());
    }

    ngOnInit(): void {
        this.currentUser = this.userService.getUserFromStorage();
        this.teamService.currentTeamEmitted$.pipe(this.untilThis).subscribe((currentTeamId) => {
            this.teamService.getCurrentUserTeams().subscribe((teams) => {
                this.teams = teams;

                if (!currentTeamId && teams.length) {
                    this.teamService.emitCurrentTeamChange(teams[0].id);
                } else {
                    this.currentTeam = this.teams.find((team) => team.id === currentTeamId);
                }
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
            this.currentTeam ? `/settings/teams/edit/${this.currentTeam?.id}` : '/settings/teams/new',
        );
    }

    public changeTab(path: string) {
        this.activeTab = path;
        this.currentUrl = this.router.url;
        if (this.router.url.startsWith('/availability/edit/')) {
            this.confirmWindowService.openConfirmDialog({
                buttonsOptions: [
                    {
                        class: 'confirm-accept-button',
                        label: 'Yes',
                        onClickEvent: this.navigateEventEmitter,
                    },
                    {
                        class: 'confirm-cancel-button',
                        label: 'Cancel',
                        onClickEvent: this.navigateEventEmitter,
                    },
                ],
                title: 'Confirm Leave Page',
                message: leavePageMessage,
            });
        }
    }

    private navigateToTab() {
        this.router.navigate([`${this.activeTab}`]);
    }

    override ngOnDestroy(): void {
        this.navigateEventEmitter.unsubscribe();
    }
}
