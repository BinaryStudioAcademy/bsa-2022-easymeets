import { Component, EventEmitter, Input, Output } from '@angular/core';
import { MatSlideToggleChange } from '@angular/material/slide-toggle';
import { BaseComponent } from '@core/base/base.component';
import { IAvailabilitySlot } from '@core/models/IAvailiabilitySlot';
import { LocationType } from '@core/models/locationType';
import { AvailabilitySlotService } from '@core/services/availability-slot.service';
import { NotificationService } from '@core/services/notification.service';

@Component({
    selector: 'app-slot',
    templateUrl: './slot.component.html',
    styleUrls: ['./slot.component.sass'],
})
export class SlotComponent extends BaseComponent {
    @Input() public slot: IAvailabilitySlot;

    @Input() public hasOwner: boolean;

    @Output() isDeleted = new EventEmitter<boolean>();

    public isChecked: boolean = true;

    LocationType = LocationType;

    constructor(private http: AvailabilitySlotService, private notifications: NotificationService) {
        super();
    }

    public toggle(event: MatSlideToggleChange) {
        this.isChecked = event.checked;
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
}
