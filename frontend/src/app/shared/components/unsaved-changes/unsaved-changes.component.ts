import { Component, Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { IConfirmDialogData } from '@shared/models/confirmWindow/IConfirmDialogData';

@Component({
    selector: 'app-unsaved-changes',
    templateUrl: './unsaved-changes.component.html',
    styleUrls: ['./unsaved-changes.component.sass'],
})
export class UnsavedChangesComponent {
    dialogData: IConfirmDialogData;

    constructor(
        public dialogRef: MatDialogRef<UnsavedChangesComponent>,
        @Inject(MAT_DIALOG_DATA) public data: IConfirmDialogData,
    ) {
        this.dialogData = data;
    }

    onConfirm(): void {
        this.dialogRef.close(true);
    }

    onDismiss(): void {
        this.dialogRef.close(false);
    }
}
