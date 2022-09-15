import { Component, EventEmitter, Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { Router } from '@angular/router';
import { LocationTypeMapping } from '@core/helpers/location-type-mapping';
import { IConfirmButtonOptions } from '@shared/models/confirmWindow/IConfirmButtonOptions';
import { IConfirmDialogData } from '@shared/models/confirmWindow/IConfirmDialogData';
import { Subscription } from 'rxjs';

@Component({
    selector: 'app-slot-password-window',
    templateUrl: './slot-password-window.component.html',
    styleUrls: ['./slot-password-window.component.sass'],
})
export class SlotPasswordWindowComponent {
    title: string;

    message?: string;

    buttonsOptions?: IConfirmButtonOptions[];

    locationTypeMapping = LocationTypeMapping;

    enteredPassword: string;

    private enterPasswordEventEmitter = new EventEmitter<void>();

    private enterPasswordEventSubscription: Subscription;

    private leaveEventEmitter = new EventEmitter<void>();

    private leaveEventSubscription: Subscription;

    constructor(
        @Inject(MAT_DIALOG_DATA) public data: IConfirmDialogData,
        private dialogRef: MatDialogRef<SlotPasswordWindowComponent>,
        private router: Router,
    ) {
        this.title = data.title;
        this.message = data.message;
        this.buttonsOptions = data.buttonsOptions;

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
        /*if (this.enteredPassword === this.slot?.passwordProtection) {
            console.log('successfully');
        } else {
            this.notificationService.showErrorMessage('Incorrect slot password');
        }*/
    }

    private leaveSlotPasswordWindow() {
        this.router.navigateByUrl('');
        this.dialogRef.close();
    }
}
