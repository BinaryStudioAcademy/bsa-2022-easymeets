import { Component, EventEmitter, Input, Output } from '@angular/core';
import { MatSlideToggleChange } from '@angular/material/slide-toggle';
import { IAvailabilitySlot } from '@core/models/IAvailiabilitySlot';
import { AvailabilitySlotService } from '@core/services/availability-slot.service';
import { NotificationService } from '@core/services/notification.service';
import { Subject, takeUntil } from 'rxjs';

@Component({
    selector: 'app-slot',
    templateUrl: './slot.component.html',
    styleUrls: ['./slot.component.sass'],
})
export class SlotComponent {
    @Input() public slot: IAvailabilitySlot;

    @Input() public hasOwner: boolean;

    @Output() isDeleted = new EventEmitter<boolean>();

    public isChecked: boolean = true;

    private unsubscribe$ = new Subject<void>();

    // eslint-disable-next-line no-empty-function
    constructor(private http: AvailabilitySlotService, private notifications: NotificationService) {}

    public toggle(event: MatSlideToggleChange) {
        this.isChecked = event.checked;
    }

    public deleteSlot() {
        this.http
            .deleteSlot(this.slot.id)
            .pipe(takeUntil(this.unsubscribe$))
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
}
