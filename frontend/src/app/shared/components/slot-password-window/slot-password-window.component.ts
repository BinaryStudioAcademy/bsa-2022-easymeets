import { Component, EventEmitter, Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { LocationTypeMapping } from '@core/helpers/location-type-mapping';
import { IConfirmButtonOptions } from '@shared/models/confirmWindow/IConfirmButtonOptions';
import { IConfirmDialogData } from '@shared/models/confirmWindow/IConfirmDialogData';

@Component({
    selector: 'app-slot-password-window',
    templateUrl: './slot-password-window.component.html',
    styleUrls: ['./slot-password-window.component.sass'],
})
export class SlotPasswordWindowComponent {
    title: string;

    message?: string;

    buttonsOptions: IConfirmButtonOptions[];

    locationTypeMapping = LocationTypeMapping;

    constructor(
        @Inject(MAT_DIALOG_DATA) public data: IConfirmDialogData,
        private dialogRef: MatDialogRef<SlotPasswordWindowComponent>,
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
