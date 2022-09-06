import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { ITeamMember } from '@core/models/ITeamMember';
import { TeamService } from '@core/services/team.service';
import { Role } from '@shared/enums/role';
import { Status } from '@shared/enums/status';

const ELEMENT_DATA: ITeamMember[] = [
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
];

@Component({
    selector: 'app-team-members',
    templateUrl: './team-members.component.html',
    styleUrls: ['./team-members.component.sass'],
})
export class TeamMembersComponent extends BaseComponent implements OnInit {
    teamMembers: ITeamMember[] = [];

    displayedColumns: string[] = ['name-email', 'role', 'page', 'calendar-connected', 'action'];

    dataSource = ELEMENT_DATA;

    teamMemberRoleValues = Object.values(Role);

    teamMemberStatusValues = Object.values(Status);

    teamId: number;

    constructor(public teamService: TeamService, private route: ActivatedRoute) {
        super();
    }

    ngOnInit(): void {
        this.route.params.subscribe((params) => (this.teamId = params['id']));

        this.teamService
            .getTeamMembers(this.teamId)
            .pipe(this.untilThis)
            .subscribe((members) => {
                this.teamMembers = members;
                console.log(this.teamMembers);
            });
    }

    isActiveStatus(status: Status) {
        return status === Status.Active;
    }
}
