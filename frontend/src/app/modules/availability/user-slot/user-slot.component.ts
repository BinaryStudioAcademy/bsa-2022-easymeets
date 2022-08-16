import { Component, EventEmitter, Input, Output } from '@angular/core';
import { IAvailabilitySlot } from '@core/models/IAvailiabilitySlot';
import { IUser } from '@core/models/IUser';
import { AvailabilitySlotService } from '@core/services/availability-slot.service';
import { SpinnerService } from '@core/services/spinner.service';
import { Subject } from 'rxjs';

@Component({
    selector: 'app-user-slot',
    templateUrl: './user-slot.component.html',
    styleUrls: ['./user-slot.component.sass'],
})
export class UserSlotComponent {
    @Input() public userSlots: Array<IAvailabilitySlot>;

    @Input() public currentUser: IUser;

    @Output() isReload = new EventEmitter<boolean>();

    private unsubscribe$ = new Subject<void>();

    // eslint-disable-next-line no-empty-function
    constructor(public spinnerService: SpinnerService, private availabilitySlotService: AvailabilitySlotService) {}

    isDeleted(isRemove: any) {
        this.isReload.emit(isRemove);
    }
}
