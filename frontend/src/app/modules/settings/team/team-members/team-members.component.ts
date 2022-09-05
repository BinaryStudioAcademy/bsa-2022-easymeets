import { Component, OnInit } from '@angular/core';
import { ITeamMember } from '@core/models/ITeamMember';
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
export class TeamMembersComponent implements OnInit {
    teamMembers: ITeamMember[] = [];

    displayedColumns: string[] = ['name-email', 'role', 'page', 'calendar-connected', 'action'];

    dataSource = ELEMENT_DATA;

    teamMemberRoleValues = Object.values(Role);

    teamMemberStatusValues = Object.values(Status);

    constructor() {}

    ngOnInit(): void {}

    isActiveStatus(status: Status) {
        return status === Status.Active;
    }
}
