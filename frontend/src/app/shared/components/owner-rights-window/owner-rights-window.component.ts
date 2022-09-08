import { Component, EventEmitter, Inject, OnInit } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { BaseComponent } from '@core/base/base.component';
import { ITeamMember } from '@core/models/ITeamMember';
import { NotificationService } from '@core/services/notification.service';
import { TeamService } from '@core/services/team.service';
import { Role } from '@shared/enums/role';
import { IConfirmButtonOptions } from '@shared/models/confirmWindow/IConfirmButtonOptions';
import { ITeamMembersDialogData } from '@shared/models/ITeamMembersDialogData';

@Component({
    selector: 'app-owner-rights-window',
    templateUrl: './owner-rights-window.component.html',
    styleUrls: ['./owner-rights-window.component.sass'],
})
export class OwnerRightsWindowComponent extends BaseComponent implements OnInit {
    title: string;

    message?: string;

    buttonsOptions?: IConfirmButtonOptions[];

    teamMembers?: ITeamMember[];

    teamId?: number;

    Role = Role;

    currentOwnerId?: bigint;

    constructor(
        @Inject(MAT_DIALOG_DATA) public data: ITeamMembersDialogData,
        private dialogRef: MatDialogRef<OwnerRightsWindowComponent>,
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

    ngOnInit(): void {
        this.currentOwnerId = this.teamMembers?.find((x) => x.role === Role.Owner)?.id;
    }

    onClick(event: EventEmitter<void>) {
        event?.next();
        this.dialogRef.close();
    }

    selectUserToDelegateRights(teamMember: ITeamMember) {
        teamMember.role = Role.Owner;

        this.teamService
            .updateTeamMember(teamMember)
            .pipe(this.untilThis)
            .subscribe(
                () => {},
                (error) => {
                    this.notificationService.showErrorMessage(error);
                },
            );

        this.teamService
            .deleteTeamMember(this.currentOwnerId)
            .pipe(this.untilThis)
            .subscribe(
                () => {
                    this.notificationService.showSuccessMessage('Team member was successfully deleted');
                },
                (error) => {
                    this.notificationService.showErrorMessage(error);
                },
            );

        this.dialogRef.close();
    }
}
