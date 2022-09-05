import { Component, Input, OnInit } from '@angular/core';
import { BaseComponent } from '@core/base/base.component';
import { LocationTypeMapping } from '@core/helpers/location-type-mapping';
import { IUserPersonalAndTeamSlots } from '@core/models/IUserPersonalAndTeamSlots';
import { AvailabilitySlotService } from '@core/services/availability-slot.service';
import { SpinnerService } from '@core/services/spinner.service';

@Component({
    selector: 'app-external-booking-choose-meeting-page',
    templateUrl: './external-booking-choose-meeting-page.component.html',
    styleUrls: ['./external-booking-choose-meeting-page.component.sass'],
})
export class ExternalBookingMeetingComponent extends BaseComponent implements OnInit {
    @Input() selectedUserId: bigint;

    selectedUserAvailabilitySlots: IUserPersonalAndTeamSlots;

    locationTypeMapping = LocationTypeMapping;

    constructor(public spinnerService: SpinnerService, private availabilitySlotService: AvailabilitySlotService) {
        super();
    }

    ngOnInit(): void {
        this.availabilitySlotService
            .getUserPersonalAndTeamSlots(this.selectedUserId)
            .pipe(this.untilThis)
            .subscribe((resp) => {
                this.selectedUserAvailabilitySlots = resp;
                this.spinnerService.hide();
            });
    }
}
