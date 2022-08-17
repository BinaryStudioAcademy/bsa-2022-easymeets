import { Component, Input } from '@angular/core';
import { Router } from '@angular/router';
import { getExternalBookingTimeSlotsItems } from '@core/helpers/external-booking-time-slots-helper';
import { IDayTimeSlot } from '@core/models/IDayTimeSlot';
import { IUserPersonalAndTeamSlots } from '@core/models/IUserPersonalAndTeamSlots';
import { AvailabilitySlotService } from '@core/services/availability-slot.service';
import { SpinnerService } from '@core/services/spinner.service';

@Component({
    selector: 'app-external-booking-choose-time-page',
    templateUrl: './external-booking-choose-time-page.component.html',
    styleUrls: ['./external-booking-choose-time-page.component.sass'],
})
export class ExternalBookingChooseTimeComponent {
    @Input() selectedUserId: number;

    public selectedUserAvailabilitySlots: IUserPersonalAndTeamSlots;

    public daysWithTimeRange: IDayTimeSlot[] = getExternalBookingTimeSlotsItems();

    constructor(
        public spinnerService: SpinnerService,
        private availabilitySlotService: AvailabilitySlotService,
        private router: Router,
    ) {
        this.availabilitySlotService.getUserPersonalAndTeamSlots(this.selectedUserId).subscribe((slots) => {
            this.selectedUserAvailabilitySlots = slots;
        });
    }
}
