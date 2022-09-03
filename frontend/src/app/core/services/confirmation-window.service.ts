import { Injectable } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { ConfirmationWindowComponent } from '@shared/components/confirmation-window/confirmation-window.component';
import { UnsavedChangesComponent } from '@shared/components/unsaved-changes/unsaved-changes.component';
import { confirmLeaveTitle, leavePageMessage } from '@shared/constants/shared-messages';
import { IConfirmDialogData } from '@shared/models/confirmWindow/IConfirmDialogData';
import { Observable } from 'rxjs';

@Injectable({ providedIn: 'root' })
export class ConfirmationWindowService {
    // eslint-disable-next-line no-empty-function
    constructor(private dialog: MatDialog) {}

    openConfirmDialog(data: IConfirmDialogData) {
        return this.dialog
            .open(ConfirmationWindowComponent, {
                data,
            })
            .afterClosed();
    }

    confirmLeaveDialog(): Observable<boolean> {
        return this.dialog
            .open(UnsavedChangesComponent, {
                data: {
                    title: confirmLeaveTitle,
                    message: leavePageMessage,
                },
            })
            .afterClosed();
    }
}
