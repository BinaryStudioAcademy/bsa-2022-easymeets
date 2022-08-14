import { Component, Input, OnInit } from '@angular/core';
import { AvailabilitySlotsGroupByTeamsDto } from '@core/models/availability-slots-group-by-team';
import { AvailabilitySlot } from '@core/models/availiability-slot';
import { SpinnerService } from '@core/services/spinner.service';

@Component({
    selector: 'app-team',
    templateUrl: './team.component.html',
    styleUrls: ['./team.component.sass'],
})
export class TeamComponent implements OnInit {
    @Input() public teamSlot: AvailabilitySlotsGroupByTeamsDto;

    public slots: Array<AvailabilitySlot>;

    public teamName: string;

    // eslint-disable-next-line no-empty-function
    constructor(public spinnerService: SpinnerService) {}

    ngOnInit(): void {
        this.slots = this.teamSlot.availabilitySlots;
        this.teamName = this.teamSlot.name;
    }
}
