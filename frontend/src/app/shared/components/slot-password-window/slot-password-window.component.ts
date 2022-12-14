import { Component, EventEmitter, Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { Router } from '@angular/router';
import { LocationTypeMapping } from '@core/helpers/location-type-mapping';
import { AvailabilitySlotService } from '@core/services/availability-slot.service';
import { NotificationService } from '@core/services/notification.service';
import { IConfirmDialogData } from '@shared/models/confirmWindow/IConfirmDialogData';

@Component({
    selector: 'app-slot-password-window',
    templateUrl: './slot-password-window.component.html',
    styleUrls: ['./slot-password-window.component.sass'],
})
export class SlotPasswordWindowComponent {
    locationTypeMapping = LocationTypeMapping;

    enteredPassword: string;

    private enterPasswordEventEmitter = new EventEmitter<void>();

    private leaveEventEmitter = new EventEmitter<void>();

    constructor(
        @Inject(MAT_DIALOG_DATA) public data: IConfirmDialogData,
        private dialogRef: MatDialogRef<SlotPasswordWindowComponent>,
        private router: Router,
        private availabilitySlotService: AvailabilitySlotService,
        private notificationService: NotificationService,
    ) {
        this.leaveEventEmitter.subscribe(() => this.leaveSlotPasswordWindow());
        this.enterPasswordEventEmitter.subscribe(() => this.enterPassword());

        this.addButtonsInWindow();
    }

    onClick(event: EventEmitter<void>) {
        event?.next();
    }

    private addButtonsInWindow() {
        this.data.buttonsOptions = [
            {
                class: 'confirm-accept-button',
                label: 'Ok',
                onClickEvent: this.enterPasswordEventEmitter,
            },
            {
                class: 'confirm-cancel-button',
                label: 'Cancel',
                onClickEvent: this.leaveEventEmitter,
            },
        ];
    }

    private enterPassword() {
        this.availabilitySlotService
            .validateSlotPassword(this.enteredPassword, this.data.slotLink)
            .subscribe((resp) => {
                if (resp) {
                    this.notificationService.showSuccessMessage('Entered slot password is correct');
                    this.dialogRef.close();
                } else {
                    this.notificationService.showErrorMessage('Entered slot password is incorrect');
                }
            });
    }

    private leaveSlotPasswordWindow() {
        this.router.navigateByUrl('');
        this.dialogRef.close();
    }
}
