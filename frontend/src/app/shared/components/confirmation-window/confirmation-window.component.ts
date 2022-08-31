import { Component, EventEmitter, Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { LocationTypeMapping } from '@core/helpers/location-type-mapping';
import { INewMeetingMember } from '@core/models/INewMeetingTeamMember';
import { LocationType } from '@shared/enums/locationType';
import { IConfirmButtonOptions } from '@shared/models/confirmWindow/IConfirmButtonOptions';
import { IConfirmDialogData } from '@shared/models/confirmWindow/IConfirmDialogData';

@Component({
    selector: 'app-confirmation-window',
    templateUrl: './confirmation-window.component.html',
    styleUrls: ['./confirmation-window.component.sass'],
})
export class ConfirmationWindowComponent {
    title: string;

    message?: string;

    buttonsOptions: IConfirmButtonOptions[];

    titleImagePath?: string;

    date?: string;

    time?: Date;

    duration?: number;

    meetingName?: string;

    participants?: INewMeetingMember[] = [];

    location?: LocationType;

    link?: string;

    maxVisibleMembers: number = 10;

    locationTypeMapping = LocationTypeMapping;

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
