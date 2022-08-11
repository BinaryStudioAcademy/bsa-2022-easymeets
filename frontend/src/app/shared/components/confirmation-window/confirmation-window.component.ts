import { Component, Inject, Input } from '@angular/core';
import { MAT_DIALOG_DATA } from '@angular/material/dialog';
import { IConfirmButtonOptions } from '@core/models/IConfirmButtonOptions';
import { IConfirmDialogData } from '@core/models/IConfirmDialogData';

@Component({
    selector: 'app-confirmation-window',
    templateUrl: './confirmation-window.component.html',
    styleUrls: ['./confirmation-window.component.sass'],
})
export class ConfirmationWindowComponent {
    @Input() public confirmDialogData: IConfirmDialogData;

    public title: string;

    public message: string;

    public acceptButtonOptions: IConfirmButtonOptions;

    public cancelButtonOptions: IConfirmButtonOptions;

    public isHasAcceptButton: boolean;

    public isHasCancelButton: boolean;

    constructor(
        @Inject(MAT_DIALOG_DATA) public data: IConfirmDialogData,
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
