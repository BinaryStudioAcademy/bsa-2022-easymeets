import { Component, Input, OnInit } from '@angular/core';
import { AvailabilitySlot } from '@core/models/availiability-slot';
import { TeamWithSlots } from '@core/models/team-with-slot';
import { SpinnerService } from '@core/services/spinner.service';

@Component({
    selector: 'app-team',
    templateUrl: './team.component.html',
    styleUrls: ['./team.component.sass'],
})
export class TeamComponent implements OnInit {
    @Input() public team: TeamWithSlots;

    public slots: Array<AvailabilitySlot>;

    // eslint-disable-next-line no-empty-function
    constructor(public spinnerService: SpinnerService) {}

    ngOnInit(): void {
        this.slots = this.team.availabilitySlots;
    }
}
