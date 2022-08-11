import { Component } from '@angular/core';
import { AvailabilitySlot } from '@core/models/availiability-slot';
import { AvailabilityService } from '@core/services/availability.service';

@Component({
    selector: 'app-availability-page',
    templateUrl: './availability-page.component.html',
    styleUrls: ['./availability-page.component.sass'],
})
export class AvailabilityPageComponent {
    public availabilitySlots: AvailabilitySlot[];

    public loadingSlots: boolean;

    constructor(private availabilitySlotService: AvailabilityService) {
        this.getAllAvailabilitySlotsForTeam();
    }

    public getAllAvailabilitySlotsForTeam() {
        this.loadingSlots = true;
        this.availabilitySlotService
            .getAvailabilitySlots()
            .subscribe(
                (resp) => {
                    this.loadingSlots = false;

                    this.availabilitySlots = resp;
                },
            );
    }
}
