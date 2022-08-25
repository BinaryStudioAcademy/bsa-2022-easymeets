import { Component, EventEmitter, Input, OnDestroy, Output } from '@angular/core';
import { MatSlideToggleChange } from '@angular/material/slide-toggle';
import { Router } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { IAvailabilitySlot } from '@core/models/IAvailiabilitySlot';
import { LocationType } from '@core/models/locationType';
import { AvailabilitySlotService } from '@core/services/availability-slot.service';
import { ConfirmationWindowService } from '@core/services/confirmation-window.service';
import { NotificationService } from '@core/services/notification.service';
import { deletionMessage } from '@shared/constants/shared-messages';
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
    }

    public toggle(event: MatSlideToggleChange) {
        this.isChecked = event.checked;
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

    override ngOnDestroy(): void {
        super.ngOnDestroy();

        this.deleteEventSubscription.unsubscribe();
    }
}
