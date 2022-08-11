import { Component } from '@angular/core';
import { getDefaultTeams } from '@core/helpers/slots-data-helper';
import { TeamWithSlot } from '@core/models/team-with-slot';
import { AvailabilitySlotService } from '@core/services/availability-slot.service';

@Component({
    selector: 'app-availability-page',
    templateUrl: './availability-page.component.html',
    styleUrls: ['./availability-page.component.sass'],
})
export class AvailabilityPageComponent {
    public teams: Array<TeamWithSlot>;

    public loadingSlots: boolean;

    constructor(private availabilitySlotService: AvailabilitySlotService) {
        this.getAllAvailabilitySlotsForTeam();
        this.teams = getDefaultTeams();
    }

    public getAllAvailabilitySlotsForTeam() {
        this.loadingSlots = true;
        this.availabilitySlotService
            .getAvailabilitySlots()
            .subscribe(
                (resp) => {
                    this.loadingSlots = false;
                    console.log(resp);
                    //this.availabilitySlots = resp;
                },
                (error) => {
                    console.log(error);
                },
            );
    }
}
