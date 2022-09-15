import { Component, EventEmitter, Inject, OnDestroy } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { Router } from '@angular/router';
import { LocationTypeMapping } from '@core/helpers/location-type-mapping';
import { AvailabilitySlotService } from '@core/services/availability-slot.service';
import { NotificationService } from '@core/services/notification.service';
import { IConfirmButtonOptions } from '@shared/models/confirmWindow/IConfirmButtonOptions';
import { ISlotPasswordData } from '@shared/models/confirmWindow/ISlotPasswordData';
import { Subscription } from 'rxjs';

@Component({
    selector: 'app-slot-password-window',
    templateUrl: './slot-password-window.component.html',
    styleUrls: ['./slot-password-window.component.sass'],
})
export class SlotPasswordWindowComponent implements OnDestroy {
    title: string;

    message?: string;

    buttonsOptions?: IConfirmButtonOptions[];

    locationTypeMapping = LocationTypeMapping;

    enteredPassword: string;

    private slotLink: string;

    private enterPasswordEventEmitter = new EventEmitter<void>();

    private enterPasswordEventSubscription: Subscription;

    private leaveEventEmitter = new EventEmitter<void>();

    private leaveEventSubscription: Subscription;

    constructor(
        @Inject(MAT_DIALOG_DATA) public data: ISlotPasswordData,
        private dialogRef: MatDialogRef<SlotPasswordWindowComponent>,
        private router: Router,
        private availabilitySlotService: AvailabilitySlotService,
        private notificationService: NotificationService,
    ) {
        this.title = data.title;
        this.message = data.message;
        this.buttonsOptions = data.buttonsOptions;
        this.slotLink = data.slotLink;

        this.addEventsSubscription();
    }

    onClick(event: EventEmitter<void>) {
        event?.next();
    }

    private addEventsSubscription() {
        this.leaveEventSubscription = this.leaveEventEmitter.subscribe(() => this.leaveSlotPasswordWindow());
        this.enterPasswordEventSubscription = this.enterPasswordEventEmitter.subscribe(() => this.enterPassword());

        this.buttonsOptions = [
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
        this.availabilitySlotService.validateSlotPassword(this.slotLink, this.enteredPassword).subscribe((resp) => {
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

    ngOnDestroy(): void {
        this.enterPasswordEventSubscription.unsubscribe();
        this.leaveEventSubscription.unsubscribe();
    }
}
