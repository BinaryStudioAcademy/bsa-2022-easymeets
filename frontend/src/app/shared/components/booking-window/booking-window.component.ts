import { Component, EventEmitter, Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { LocationTypeMapping } from '@core/helpers/location-type-mapping';
import { INewMeetingMember } from '@core/models/INewMeetingTeamMember';
import { LocationType } from '@shared/enums/locationType';
import { IConfirmButtonOptions } from '@shared/models/confirmWindow/IConfirmButtonOptions';
import { IConfirmDialogData } from '@shared/models/confirmWindow/IConfirmDialogData';

import { ConfirmationWindowComponent } from '../confirmation-window/confirmation-window.component';

@Component({
    selector: 'app-booking-window',
    templateUrl: './booking-window.component.html',
    styleUrls: ['./booking-window.component.sass'],
})
export class BookingWindowComponent {
    maxVisibleMembers: number = 10;

    title: string;

    message?: string;

    titleImagePath?: string;

    buttonsOptions: IConfirmButtonOptions[];

    date?: string;

    time?: Date;

    duration?: number;

    meetingName?: string;

    participants?: INewMeetingMember[];

    location?: LocationType;

    link?: string;

    locationTypeMapping = LocationTypeMapping;

    constructor(
        @Inject(MAT_DIALOG_DATA) public data: IConfirmDialogData,
        private dialogRef: MatDialogRef<ConfirmationWindowComponent>,
    ) {
        this.title = data.title;
        this.message = data.message;
        this.buttonsOptions = data.buttonsOptions;
    }

    onClick(event: EventEmitter<void>) {
        event?.next();
        this.dialogRef.close();
    }
}
