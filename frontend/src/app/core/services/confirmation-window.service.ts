import { Injectable } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { ConfirmDialogData } from '@core/models/ConfirmDialogData';
import { ConfirmationWindowComponent } from '@shared/components/confirmation-window/confirmation-window.component';
import { Observable } from 'rxjs';

@Injectable({ providedIn: 'root' })
export class ConfirmationWindowService {
    // eslint-disable-next-line no-empty-function
    constructor(private dialog: MatDialog) {
    }

    openConfirmDialog(data: ConfirmDialogData): Observable<boolean> {
        return this.dialog
            .open(ConfirmationWindowComponent, {
                data,
            })
            .afterClosed();
    }
}
