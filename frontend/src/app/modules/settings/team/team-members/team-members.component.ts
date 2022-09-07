import { Component, EventEmitter, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { ITeamMember } from '@core/models/ITeamMember';
import { ConfirmationWindowService } from '@core/services/confirmation-window.service';
import { TeamService } from '@core/services/team.service';
import { Role } from '@shared/enums/role';
import { Status } from '@shared/enums/status';
import { Subscription } from 'rxjs';

/*const ELEMENT_DATA: ITeamMember[] = [
    {
        image: '',
        name: 'Heorhii Matviichuk',
        email: 'heorhiiheorhii@email.com',
        pageLink: '.../link',
        role: Role.Member,
        status: Status.Active,
    },
    {
        image: '',
        name: 'Heorhii Matviichuk',
        email: 'heorhiiheorhii@email.com',
        pageLink: '',
        role: Role.Owner,
        status: Status.Pending,
    },
];*/

@Component({
    selector: 'app-team-members',
    templateUrl: './team-members.component.html',
    styleUrls: ['./team-members.component.sass'],
})
export class TeamMembersComponent extends BaseComponent implements OnInit {
    teamMembers: ITeamMember[] = [];

    displayedColumns: string[] = ['name-email', 'role', 'page', 'calendar-connected', 'action'];

    /*dataSource = ELEMENT_DATA;*/

    teamMemberRoleValues = Object.values(Role);

    teamMemberStatusValues = Object.values(Status);

    teamId: number;

    private reloadEventEmitter = new EventEmitter<void>();

    private reloadEventSubscription: Subscription;

    constructor(
        public teamService: TeamService,
        public confirmationWindowService: ConfirmationWindowService,
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
                console.log(this.teamMembers);
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
            .subscribe((members) => {
                this.reloadTeamMembers();
                console.log(members);
            });
    }
}
