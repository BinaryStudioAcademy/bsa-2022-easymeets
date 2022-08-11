import { Component, Input } from '@angular/core';
import { AvailabilitySlot } from '@core/models/availiability-slot';
import { User } from '@core/models/user';
import { SpinnerService } from '@core/services/spinner.service';

@Component({
    selector: 'app-user-slot',
    templateUrl: './user-slot.component.html',
    styleUrls: ['./user-slot.component.sass'],
})
export class UserSlotComponent {
    @Input() public userSlots: Array<AvailabilitySlot>;

    @Input() public currentUser: User;

    // eslint-disable-next-line no-empty-function
    constructor(public spinnerService: SpinnerService) {}
}
