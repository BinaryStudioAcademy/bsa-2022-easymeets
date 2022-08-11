import { Component } from '@angular/core';
import { AvailabilitySlot } from '@core/models/availiability-slot';
import { TeamWithSlots } from '@core/models/team-with-slot';
import { AvailabilitySlotService } from '@core/services/availability-slot.service';

@Component({
    selector: 'app-availability-page',
    templateUrl: './availability-page.component.html',
    styleUrls: ['./availability-page.component.sass'],
})
export class AvailabilityPageComponent {
    public teams: Array<TeamWithSlots>;

    public userSlots: Array<AvailabilitySlot>;

    public loadingSlots: boolean;

    constructor(private availabilitySlotService: AvailabilitySlotService) {
        this.getAllAvailabilitySlotsForTeam();
    }

    public getAllAvailabilitySlotsForTeam() {
        this.loadingSlots = true;
        this.availabilitySlotService
            .getAvailabilitySlotsGroupByTeams(4)
            .subscribe(
                (resp) => {
                    // eslint-disable-next-line no-debugger
                    debugger;
                    this.loadingSlots = false;
                    console.log(resp);
                    this.teams = resp;
                    console.log(this.teams);
                },
                (error) => {
                    console.log(error);
                },
            );
    }
}
