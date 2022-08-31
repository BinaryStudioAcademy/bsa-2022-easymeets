import { Component, EventEmitter, Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { INewMeetingMember } from '@core/models/INewMeetingTeamMember';
import { IConfirmButtonOptions } from '@shared/models/confirmWindow/IConfirmButtonOptions';
import { IConfirmDialogData } from '@shared/models/confirmWindow/IConfirmDialogData';

@Component({
    selector: 'app-confirmation-window',
    templateUrl: './confirmation-window.component.html',
    styleUrls: ['./confirmation-window.component.sass'],
})
export class ConfirmationWindowComponent {
    public title: string;

    public message?: string;

    public buttonsOptions: IConfirmButtonOptions[];

    public titleImagePath?: string;

    public date?: string;

    public time?: Date;

    public duration?: number;

    public meetingName?: string;

    public participants?: INewMeetingMember[] = [];

    public location?: string;

    public link?: string;

    public maxVisibleMembers: number = 10;

    constructor(
        @Inject(MAT_DIALOG_DATA) public data: IConfirmDialogData,
        private dialogRef: MatDialogRef<ConfirmationWindowComponent>,
    ) {
        this.title = data.title;
        this.message = data.message;
        this.buttonsOptions = data.buttonsOptions;
        this.titleImagePath = data.titleImagePath;
        this.date = data.date;
        this.time = data.time;
        this.duration = data.duration;
        this.meetingName = data.meetingName;
        this.participants = data.participants;
        this.location = data.location;
        this.link = data.link;
    }

    onClick(event: EventEmitter<void>) {
        event?.next();
        this.dialogRef.close();
    }
}
