import { Component, Input, OnInit } from '@angular/core';
import { AvailabilitySlot } from '@core/models/availiability-slot';

@Component({
    selector: 'app-user-slot',
    templateUrl: './user-slot.component.html',
    styleUrls: ['./user-slot.component.sass'],
})
export class UserSlotComponent implements OnInit {
    @Input() public userSlots: Array<AvailabilitySlot>;

    // eslint-disable-next-line @angular-eslint/no-empty-lifecycle-method
    ngOnInit(): void {
    }
}
