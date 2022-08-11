import { Injectable } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { IConfirmDialogData } from '@core/models/IConfirmDialogData';
import { ConfirmationWindowComponent } from '@shared/components/confirmation-window/confirmation-window.component';
import { Observable } from 'rxjs';

@Injectable({ providedIn: 'root' })
export class ConfirmationWindowService {
    // eslint-disable-next-line no-empty-function
    constructor(private dialog: MatDialog) {
    }

    openConfirmDialog(data: IConfirmDialogData): Observable<boolean> {
        return this.dialog
            .open(ConfirmationWindowComponent, {
                data,
            })
            .afterClosed();
    }
}
