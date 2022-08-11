import { Component, Inject, Input } from '@angular/core';
import { MAT_DIALOG_DATA } from '@angular/material/dialog';
import { ConfirmButtonOptions } from '@core/models/ConfirmButtonOptions';
import { ConfirmDialogData } from '@core/models/ConfirmDialogData';

@Component({
    selector: 'app-confirmation-window',
    templateUrl: './confirmation-window.component.html',
    styleUrls: ['./confirmation-window.component.sass'],
})
export class ConfirmationWindowComponent {
    @Input() public confirmDialogData: ConfirmDialogData;

    public title: string;

    public message: string;

    public acceptButtonOptions: ConfirmButtonOptions;

    public cancelButtonOptions: ConfirmButtonOptions;

    public isHasAcceptButton: boolean;

    public isHasCancelButton: boolean;

    constructor(
        @Inject(MAT_DIALOG_DATA) public data: ConfirmDialogData,
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
}
