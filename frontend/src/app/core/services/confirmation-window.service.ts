import { ComponentType } from '@angular/cdk/portal';
import { Injectable } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { ConfirmationWindowComponent } from '@shared/components/confirmation-window/confirmation-window.component';
import { IConfirmDialogData } from '@shared/models/confirmWindow/IConfirmDialogData';

@Injectable({ providedIn: 'root' })
export class ConfirmationWindowService {
    // eslint-disable-next-line no-empty-function
    constructor(private dialog: MatDialog) {}

    openConfirmDialog(data: IConfirmDialogData, component: ComponentType<any> = ConfirmationWindowComponent) {
        return this.dialog
            .open(component, {
                data,
            })
            .afterClosed();
    }
}
