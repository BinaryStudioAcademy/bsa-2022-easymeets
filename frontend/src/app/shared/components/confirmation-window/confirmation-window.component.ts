import { Component, Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { IConfirmButtonOptions } from '@shared/models/confirmWindow/IConfirmButtonOptions';
import { IConfirmDialogData } from '@shared/models/confirmWindow/IConfirmDialogData';

@Component({
    selector: 'app-confirmation-window',
    templateUrl: './confirmation-window.component.html',
    styleUrls: ['./confirmation-window.component.sass'],
})
export class ConfirmationWindowComponent {
    public title: string;

    public message: string;

    public acceptButtonOptions: IConfirmButtonOptions;

    public cancelButtonOptions: IConfirmButtonOptions;

    public isHasAcceptButton: boolean;

    public isHasCancelButton: boolean;

    constructor(
        @Inject(MAT_DIALOG_DATA) public data: IConfirmDialogData,
        private dialogRef: MatDialogRef<ConfirmationWindowComponent>,
    ) {
        this.title = data.title;
        this.message = data.message;

        if (data.acceptButton !== undefined) {
            this.isHasAcceptButton = true;
            this.acceptButtonOptions = data.acceptButton;
        }

        if (data.cancelButton !== undefined) {
            this.isHasCancelButton = true;
            this.cancelButtonOptions = data.cancelButton;
        }
    }

    cancel() {
        this.dialogRef.close(false);
    }

    accept() {
        this.dialogRef.close(true);
    }
}
