import { ENTER, SPACE } from '@angular/cdk/keycodes';
import { Component, EventEmitter, Inject } from '@angular/core';
import { MatChipInputEvent } from '@angular/material/chips';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { BaseComponent } from '@core/base/base.component';
import { ITeamMember } from '@core/models/ITeamMember';
import { IUser } from '@core/models/IUser';
import { NotificationService } from '@core/services/notification.service';
import { TeamService } from '@core/services/team.service';
import { UserService } from '@core/services/user.service';
import { Role } from '@shared/enums/role';
import { Status } from '@shared/enums/status';
import { IConfirmButtonOptions } from '@shared/models/confirmWindow/IConfirmButtonOptions';
import { ITeamMembersDialogData } from '@shared/models/ITeamMembersDialogData';

@Component({
    selector: 'app-team-members-window',
    templateUrl: './team-members-window.component.html',
    styleUrls: ['./team-members-window.component.sass'],
})
export class TeamMembersWindowComponent extends BaseComponent {
    title: string;

    message?: string;

    buttonsOptions?: IConfirmButtonOptions[];

    teamMembers?: ITeamMember[];

    teamId?: number;

    searchedUsers: IUser[];

    query: string;

    usersToAdd: IUser[] = [];

    readonly separatorKeysCodes = [ENTER, SPACE] as const;

    constructor(
        @Inject(MAT_DIALOG_DATA) public data: ITeamMembersDialogData,
        private dialogRef: MatDialogRef<TeamMembersWindowComponent>,
        private userService: UserService,
        private teamService: TeamService,
        private notificationService: NotificationService,
    ) {
        super();
        this.title = data.title;
        this.buttonsOptions = data.buttonsOptions;
        this.teamMembers = data.teamMembers;
        this.teamId = data.teamId;
        this.message = data.message;
    }

    onClick(event: EventEmitter<void>) {
        event?.next();
        this.dialogRef.close();
    }

    addOnBlur = true;

    teamMembersEmails: string[] = [];

    add(event: MatChipInputEvent): void {
        const value = (event.value || '').trim();

        if (value) {
            this.teamMembersEmails.push(value);
        }
        event.chipInput!.clear();
    }

    remove(email: string): void {
        const index = this.teamMembersEmails.indexOf(email);

        if (index >= 0) {
            this.teamMembersEmails.splice(index, 1);
        }
    }

    getUsersByEmailOrName(searchData: string) {
        if (searchData.length) {
            this.userService
                .getUsersByEmailOrName(searchData)
                .pipe(this.untilThis)
                .subscribe(
                    (users) => {
                        this.searchedUsers = users;
                    },
                    (error) => {
                        this.notificationService.showErrorMessage(error);
                    },
                );
        } else {
            this.searchedUsers = [];
        }
    }

    isAddedMember(user: IUser) {
        return this.teamMembers?.some((p) => p.email === user.email);
    }

    selectUser(user: IUser) {
        this.usersToAdd = [...this.usersToAdd, user];

        const teamMember: ITeamMember = {
            id: user.id,
            image: user.image,
            name: user.userName,
            email: user.email,
            pageLink: '',
            role: Role.Member,
            status: Status.Pending,
        };

        this.teamService
            .createTeamMember(teamMember, this.teamId)
            .pipe(this.untilThis)
            .subscribe(
                () => {},
                (error) => {
                    this.notificationService.showErrorMessage(error);
                },
            );
    }

    isSelectedUserToAdd(id: bigint) {
        const isSelected: boolean = this.usersToAdd.some((x) => x.id === id);

        return { 'window-selected-user': isSelected, 'not-added-user-info': !isSelected };
    }
}
