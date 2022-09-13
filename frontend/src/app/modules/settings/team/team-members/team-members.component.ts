import { Component, EventEmitter, OnDestroy, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { ITeamMember } from '@core/models/ITeamMember';
import { ConfirmationWindowService } from '@core/services/confirmation-window.service';
import { NotificationService } from '@core/services/notification.service';
import { TeamService } from '@core/services/team.service';
import { UserService } from '@core/services/user.service';
import { deletingTheOnlyMemberOfTeamMessage } from '@shared/constants/shared-messages';
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

    teamMemberRoleValues = Object.values(Role).filter((o) => o !== Role.Owner);

    teamMemberStatusValues = Object.values(Status);

    teamId: number;

    ownerIdToDeleteWithTeam: bigint;

    currentUserIsMember: boolean;

    Role = Role;

    private reloadEventEmitter = new EventEmitter<void>();

    private reloadEventSubscription: Subscription;

    private deleteOwnerEventEmitter = new EventEmitter<void>();

    private deleteOwnerEventSubscription: Subscription;

    constructor(
        private teamService: TeamService,
        private confirmationWindowService: ConfirmationWindowService,
        private notificationService: NotificationService,
        private userService: UserService,
        private route: ActivatedRoute,
        private router: Router,
    ) {
        super();
        this.reloadEventSubscription = this.reloadEventEmitter.subscribe(() => this.reloadTeamMembers());
        this.deleteOwnerEventSubscription = this.deleteOwnerEventEmitter.subscribe(() => this.deleteTeamWithOwner());
    }

    ngOnInit(): void {
        this.route.params.subscribe((params) => {
            this.teamId = params['id'];
        });

        this.isCurrentUserHasMemberRole();
    }

    isCurrentUserHasMemberRole() {
        this.getTeamMembers();

        this.userService
            .getCurrentUser()
            .pipe(this.untilThis)
            .subscribe(
                (user) => {
                    this.currentUserIsMember = this.teamMembers.find((p) => p.userId === user.id)?.role === Role.Member;
                },
                (error) => {
                    this.notificationService.showErrorMessage(error);
                },
            );
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

    showNewOwnerChoosingWindow() {
        this.confirmationWindowService.openOwnerRightsDialog({
            buttonsOptions: [
                {
                    class: 'confirm-cancel-button',
                    label: 'Cancel',
                    onClickEvent: new EventEmitter<void>(),
                },
            ],
            title: 'Delegate Owner Rights',
            message: 'You want to delete owner member. Choose another team member you want to delegate your rights.',
            teamMembers: this.teamMembers,
            teamId: this.teamId,
        });
    }

    showTeamDeletingWindow(ownerId: bigint) {
        this.ownerIdToDeleteWithTeam = ownerId;
        this.confirmationWindowService.openConfirmDialog({
            buttonsOptions: [
                {
                    class: 'confirm-accept-button',
                    label: 'Yes',
                    onClickEvent: this.deleteOwnerEventEmitter,
                },
            ],
            title: 'Confirm Owner Deletion',
            message: deletingTheOnlyMemberOfTeamMessage,
        });
    }

    reloadTeamMembers() {
        this.getTeamMembers();
    }

    deleteTeamMemberById(teamMemberId: bigint) {
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

    deleteTeamMember(teamMemberId: bigint, teamMemberRole: Role) {
        if (teamMemberRole === Role.Owner) {
            if (this.teamMembers.length > 1) {
                this.showNewOwnerChoosingWindow();
            } else {
                this.showTeamDeletingWindow(teamMemberId);
            }
        } else {
            this.deleteTeamMemberById(teamMemberId);
        }
    }

    deleteTeamWithOwner() {
        this.deleteTeamMemberById(this.ownerIdToDeleteWithTeam);
        this.teamService
            .deleteTeam(this.teamId)
            .pipe(this.untilThis)
            .subscribe(
                () => {
                    this.notificationService.showSuccessMessage('Team was successfully deleted');
                    this.router.navigate(['settings']);
                },
                (error) => {
                    this.notificationService.showErrorMessage(error);
                },
            );
    }

    changeTeamMemberRole(user: ITeamMember, newRole: Role) {
        const teamMember: ITeamMember = {
            id: user.id,
            image: user.image,
            name: user.name,
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
        this.deleteOwnerEventSubscription.unsubscribe();
    }
}
