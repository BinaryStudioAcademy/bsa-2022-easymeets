import { Component } from '@angular/core';
import { AvailabilitySlot } from '@core/models/availiability-slot';
import { AvailabilitySlotService } from '@core/services/availability-slot.service';

@Component({
    selector: 'app-availability-page',
    templateUrl: './availability-page.component.html',
    styleUrls: ['./availability-page.component.sass'],
})
export class AvailabilityPageComponent {
    public availabilitySlots: AvailabilitySlot[];

    public loadingSlots: boolean;

    constructor(private availabilitySlotService: AvailabilitySlotService) {
        this.getAllAvailabilitySlotsForTeam();
    }

    public getAllAvailabilitySlotsForTeam() {
        // eslint-disable-next-line no-debugger
        debugger;
        this.loadingSlots = true;
        this.availabilitySlotService
            .getAvailabilitySlots()
            .subscribe(
                (resp) => {
                    this.loadingSlots = false;
                    // eslint-disable-next-line no-debugger
                    debugger;
                    this.availabilitySlots = resp;
                },
                (error) => {
                    // eslint-disable-next-line no-debugger
                    debugger;
                    console.log(error);
                },
            );
    }
}
