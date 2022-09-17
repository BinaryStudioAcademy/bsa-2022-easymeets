import { ENTER, SPACE } from '@angular/cdk/keycodes';
import { Component, EventEmitter, Inject } from '@angular/core';
import { MatChipInputEvent } from '@angular/material/chips';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { BaseComponent } from '@core/base/base.component';
import { ITeamMember } from '@core/models/ITeamMember';
import { IUser } from '@core/models/IUser';
import { NotificationService } from '@core/services/notification.service';
import { TeamService } from '@core/services/team.service';
import { IConfirmButtonOptions } from '@shared/models/confirmWindow/IConfirmButtonOptions';
import { ITeamMembersDialogData } from '@shared/models/ITeamMembersDialogData';
import { Subscription } from 'rxjs';

@Component({
    selector: 'app-team-members-window',
    templateUrl: './team-members-window.component.html',
    styleUrls: ['./team-members-window.component.sass'],
})
export class TeamMembersWindowComponent extends BaseComponent {
    readonly separatorKeysCodes = [ENTER, SPACE] as const;

    title: string;

    message?: string;

    buttonsOptions?: IConfirmButtonOptions[];

    teamMembers?: ITeamMember[];

    teamId?: number;

    searchedUsers: IUser[];

    query: string;

    usersToAdd: IUser[] = [];

    addOnBlur = true;

    teamMembersEmails: string[] = [];

    private sendInvitaitionEventEmitter = new EventEmitter<void>();

    private sendInvitaitionEventSubscription: Subscription;

    constructor(
        @Inject(MAT_DIALOG_DATA) public data: ITeamMembersDialogData,
        private dialogRef: MatDialogRef<TeamMembersWindowComponent>,
        private teamService: TeamService,
        private notificationService: NotificationService,
    ) {
        super();
        this.sendInvitaitionEventSubscription = this.sendInvitaitionEventEmitter.subscribe(() => this.sendInvitaition());
        this.title = data.title;
        this.buttonsOptions = data.buttonsOptions;
        if (this.buttonsOptions) {
            this.buttonsOptions[1].onClickEvent = this.sendInvitaitionEventEmitter;
        }

        this.teamMembers = data.teamMembers;
        this.teamId = data.teamId;
        this.message = data.message;
    }

    onClick(event: EventEmitter<void>) {
        event?.next();
        this.dialogRef.close();
    }

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

    sendInvitaition() {
        if (this.teamId) {
            this.teamService
                .sendInvitaionToMembers(this.teamMembersEmails, this.teamId)
                .subscribe(
                    (resp) => {
                        // eslint-disable-next-line no-debugger
                        debugger;
                        console.log(resp);
                    },
                    (error) => {
                        this.notificationService.showErrorMessage(error);
                    },
                );
        } else {
            this.notificationService.showErrorMessage('Team was not found');
        }
    }
}
