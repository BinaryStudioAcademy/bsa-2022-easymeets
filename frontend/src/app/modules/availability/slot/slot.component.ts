import { Component, EventEmitter, Input, OnDestroy, Output } from '@angular/core';
import { MatSlideToggleChange } from '@angular/material/slide-toggle';
import { Router } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { IAvailabilitySlot } from '@core/models/IAvailabilitySlot';
import { LocationType } from '@core/models/locationType';
import { AvailabilitySlotService } from '@core/services/availability-slot.service';
import { ConfirmationWindowService } from '@core/services/confirmation-window.service';
import { NotificationService } from '@core/services/notification.service';
import { activationSlotMessage, deletionMessage, inactivationSlotMessage } from '@shared/constants/shared-messages';
import { Subscription } from 'rxjs';

@Component({
    selector: 'app-slot',
    templateUrl: './slot.component.html',
    styleUrls: ['./slot.component.sass'],
})
export class SlotComponent extends BaseComponent implements OnDestroy {
    @Input() public slot: IAvailabilitySlot;

    @Input() public hasOwner: boolean;

    @Output() isDeleted = new EventEmitter<boolean>();

    private deleteEventEmitter = new EventEmitter<void>();

    private deleteEventSubscription: Subscription;

    @Output() isChangedActivity = new EventEmitter<boolean>();

    private changeActivityEventEmitter = new EventEmitter<void>();

    private changeActivitySubscription: Subscription;

    private cancelActivityEventEmitter = new EventEmitter<void>();

    private cancelActivitySubscription: Subscription;

    public isChecked: boolean = true;

    LocationType = LocationType;

    constructor(
        private http: AvailabilitySlotService,
        private notifications: NotificationService,
        private router: Router,
        private confirmWindowService: ConfirmationWindowService,
    ) {
        super();

        this.deleteEventSubscription = this.deleteEventEmitter.subscribe(() => this.deleteSlot());
        this.changeActivitySubscription = this.changeActivityEventEmitter.subscribe(() => this.changeSlotActivity());
        this.cancelActivitySubscription = this.cancelActivityEventEmitter.subscribe(() => this.cancelSlotActivity());
    }

    public goToPage(pageName: string) {
        this.router.navigate([`${pageName}`]);
    }

    public deleteButtonClick() {
        this.confirmWindowService.openConfirmDialog({
            buttonsOptions: [
                {
                    class: 'confirm-accept-button',
                    label: 'Yes',
                    onClickEvent: this.deleteEventEmitter,
                },
                {
                    class: 'confirm-cancel-button',
                    label: 'Cancel',
                    onClickEvent: new EventEmitter<void>(),
                },
            ],
            title: 'Confirm Slot Deletion',
            message: deletionMessage,
        });
    }

    public deleteSlot() {
        this.http
            .deleteSlot(this.slot.id)
            .pipe(this.untilThis)
            .subscribe(
                () => {
                    this.notifications.showSuccessMessage('Slot was successfully deleted');
                    this.deleteEvent(true);
                },
                (error) => {
                    this.notifications.showErrorMessage(error);
                },
            );
    }

    deleteEvent(isRemove: boolean) {
        this.isDeleted.emit(isRemove);
    }

    public changeSlotActivityClick(event: MatSlideToggleChange) {
        this.confirmWindowService.openConfirmDialog({
            buttonsOptions: [
                {
                    class: 'confirm-accept-button',
                    label: 'Yes',
                    onClickEvent: this.changeActivityEventEmitter,
                },
                {
                    class: 'confirm-cancel-button',
                    label: 'Cancel',
                    onClickEvent: this.cancelActivityEventEmitter,
                },
            ],
            title: event.checked ? 'Confirm Slot Activation' : 'Confirm Slot Inactivation',
            message: event.checked ? activationSlotMessage : inactivationSlotMessage,
        });
    }

    public changeSlotActivity() {
        this.http
            .updateSlotEnabling(this.slot?.id)
            .pipe(this.untilThis)
            .subscribe(
                () => {
                    this.notifications.showSuccessMessage('Slot`s activity was successfully changed');
                    this.changeActivityEvent(true);
                },
                (error) => {
                    this.notifications.showErrorMessage(error);
                },
            );
    }

    changeActivityEvent(isChanged: boolean) {
        this.isChangedActivity.emit(isChanged);
    }

    public cancelSlotActivity() {
        this.changeActivityEvent(true);
    }

    override ngOnDestroy(): void {
        super.ngOnDestroy();

        this.deleteEventSubscription.unsubscribe();
        this.changeActivitySubscription.unsubscribe();
        this.cancelActivitySubscription.unsubscribe();
    }
}
