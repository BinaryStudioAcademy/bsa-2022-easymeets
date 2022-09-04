import { Injectable } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { BookingWindowComponent } from '@shared/components/booking-window/booking-window.component';
import { ConfirmationWindowComponent } from '@shared/components/confirmation-window/confirmation-window.component';
import { IConfirmDialogData } from '@shared/models/confirmWindow/IConfirmDialogData';

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

    openBookingDialog(data: IConfirmDialogData) {
        return this.dialog
            .open(BookingWindowComponent, {
                data,
            })
            .afterClosed();
    }
}
