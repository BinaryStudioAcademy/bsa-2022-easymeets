import { Component, EventEmitter, Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { BaseComponent } from '@core/base/base.component';
import { ITeamMember } from '@core/models/ITeamMember';
import { IUser } from '@core/models/IUser';
import { TeamService } from '@core/services/team.service';
import { UserService } from '@core/services/user.service';
import { Role } from '@shared/enums/role';
import { Status } from '@shared/enums/status';
import { IConfirmButtonOptions } from '@shared/models/confirmWindow/IConfirmButtonOptions';
import { IConfirmDialogData } from '@shared/models/confirmWindow/IConfirmDialogData';

@Component({
    selector: 'app-team-members-window',
    templateUrl: './team-members-window.component.html',
    styleUrls: ['./team-members-window.component.sass'],
})
export class TeamMembersWindowComponent extends BaseComponent {
    title: string;

    message?: string;

    buttonsOptions: IConfirmButtonOptions[];

    teamMembers?: ITeamMember[];

    teamId?: number;

    searchedUsers: IUser[];

    query: string;

    usersToAdd: IUser[] = [];

    constructor(
        @Inject(MAT_DIALOG_DATA) public data: IConfirmDialogData,
        private dialogRef: MatDialogRef<TeamMembersWindowComponent>,
        private userService: UserService,
        private teamService: TeamService,
    ) {
        super();
        this.title = data.title;
        this.message = data.message;
        this.buttonsOptions = data.buttonsOptions;
        this.teamMembers = data.teamMembers;
        this.teamId = data.teamId;
    }

    onClick(event: EventEmitter<void>) {
        event?.next();
        this.dialogRef.close();
    }

    getUsersByEmailOrName(searchData: string) {
        this.userService
            .getUsersByEmailOrName(searchData)
            .pipe(this.untilThis)
            .subscribe((users) => {
                this.searchedUsers = users;
            });
    }

    isAddedMember(user: IUser) {
        return this.teamMembers?.some((p) => p.email === user.email);
    }

    selectUser(user: IUser) {
        alert(`I want to add user with id ${user.id}`);
        this.usersToAdd = [...this.usersToAdd, user];

        const teamMember: ITeamMember = {
            image: user.image,
            name: user.userName,
            email: user.email,
            pageLink: '',
            role: Role.Member,
            status: Status.Pending,
        };

        console.log(this.teamId);
        console.log(teamMember);
        /*console.log(this.usersToAdd);*/
        /*this.teamService.editTeamMembers(this.teamId, teamMember);*/
    }
}
