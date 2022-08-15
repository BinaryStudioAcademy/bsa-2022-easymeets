import { Component, EventEmitter, Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { IConfirmButtonOptions } from '@core/models/IConfirmButtonOptions';
import { IConfirmDialogData } from '@core/models/IConfirmDialogData';

@Component({
    selector: 'app-confirmation-window',
    templateUrl: './confirmation-window.component.html',
    styleUrls: ['./confirmation-window.component.sass'],
})
export class ConfirmationWindowComponent {
    public title: string;

    public message: string;

    public buttonsOptions: IConfirmButtonOptions[];

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
