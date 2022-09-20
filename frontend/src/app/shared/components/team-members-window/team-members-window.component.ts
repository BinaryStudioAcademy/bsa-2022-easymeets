import { ENTER, SPACE } from '@angular/cdk/keycodes';
import { Component, EventEmitter, Inject } from '@angular/core';
import { MatChipInputEvent } from '@angular/material/chips';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { BaseComponent } from '@core/base/base.component';
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

    teamId?: number;

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
        this.buttonsOptions = [
            {
                class: 'confirm-cancel-button',
                label: 'Cancel',
                onClickEvent: new EventEmitter<void>(),
            },
            {
                class: 'confirm-accept-button',
                label: 'Send invitation',
                onClickEvent: this.sendInvitaitionEventEmitter,
            },
        ];

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
            if (this.teamMembersEmails.length) {
                this.teamService
                    .sendInvitaionToMembers(this.teamMembersEmails, this.teamId)
                    .subscribe(
                        () => {
                            this.notificationService.showSuccessMessage('Invitation email was sent to team members emails');
                        },
                        (error) => {
                            this.notificationService.showErrorMessage(error);
                        },
                    );
            } else {
                this.notificationService.showErrorMessage('You should add at least one team member email!');
            }
        } else {
            this.notificationService.showErrorMessage('Team was not found');
        }
    }
}
