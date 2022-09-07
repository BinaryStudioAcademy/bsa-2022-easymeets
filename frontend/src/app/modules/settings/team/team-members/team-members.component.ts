import { Component, EventEmitter, OnDestroy, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { ITeamMember } from '@core/models/ITeamMember';
import { IUser } from '@core/models/IUser';
import { ConfirmationWindowService } from '@core/services/confirmation-window.service';
import { NotificationService } from '@core/services/notification.service';
import { TeamService } from '@core/services/team.service';
import { Role } from '@shared/enums/role';
import { Status } from '@shared/enums/status';
import { Subscription } from 'rxjs';

@Component({
    selector: 'app-team-members',
    templateUrl: './team-members.component.html',
    styleUrls: ['./team-members.component.sass'],
})
export class TeamMembersComponent extends BaseComponent implements OnInit, OnDestroy {
    teamMembers: ITeamMember[] = [];

    displayedColumns: string[] = ['name-email', 'role', 'page', 'calendar-connected', 'action'];

    teamMemberRoleValues = Object.values(Role);

    teamMemberStatusValues = Object.values(Status);

    teamId: number;

    private reloadEventEmitter = new EventEmitter<void>();

    private reloadEventSubscription: Subscription;

    constructor(
        private teamService: TeamService,
        private confirmationWindowService: ConfirmationWindowService,
        private notificationService: NotificationService,
        private route: ActivatedRoute,
    ) {
        super();
        this.reloadEventSubscription = this.reloadEventEmitter.subscribe(() => this.reloadTeamMembers());
    }

    ngOnInit(): void {
        this.route.params.subscribe((params) => {
            this.teamId = params['id'];
        });

        this.getTeamMembers();
    }

    getTeamMembers() {
        this.teamService
            .getTeamMembers(this.teamId)
            .pipe(this.untilThis)
            .subscribe((members) => {
                this.teamMembers = members;
            });
    }

    showTeamMembersWindow() {
        this.confirmationWindowService.openTeamMembersDialog({
            buttonsOptions: [
                {
                    class: 'confirm-accept-button',
                    label: 'Done',
                    onClickEvent: this.reloadEventEmitter,
                },
            ],
            title: 'Add Member(s)',
            teamMembers: this.teamMembers,
            teamId: this.teamId,
        });
    }

    reloadTeamMembers() {
        this.getTeamMembers();
    }

    deleteTeamMember(teamMemberId: number) {
        this.teamService
            .deleteTeamMember(teamMemberId)
            .pipe(this.untilThis)
            .subscribe(
                () => {
                    this.notificationService.showSuccessMessage('Team member was successfully deleted');
                    this.reloadTeamMembers();
                },
                (error) => {
                    this.notificationService.showErrorMessage(error);
                },
            );
    }

    changeTeamMemberRole(user: IUser, newRole: Role) {
        const teamMember: ITeamMember = {
            id: user.id,
            image: user.image,
            name: user.userName,
            email: user.email,
            pageLink: '',
            role: newRole,
            status: Status.Pending,
        };

        this.teamService
            .updateTeamMember(teamMember)
            .pipe(this.untilThis)
            .subscribe(
                () => {
                    this.notificationService.showSuccessMessage('Team member`s role was successfully changed');
                    this.reloadTeamMembers();
                },
                (error) => {
                    this.notificationService.showErrorMessage(error);
                },
            );
    }

    override ngOnDestroy(): void {
        super.ngOnDestroy();

        this.reloadEventSubscription.unsubscribe();
    }
}
