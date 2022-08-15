import { Component, Input, OnInit } from '@angular/core';
import { IAvailabilitySlotsGroupByTeamsDto } from '@core/models/IAvailabilitySlotsGroupByTeam';
import { IAvailabilitySlot } from '@core/models/IAvailiabilitySlot';
import { SpinnerService } from '@core/services/spinner.service';

@Component({
    selector: 'app-team',
    templateUrl: './team.component.html',
    styleUrls: ['./team.component.sass'],
})
export class TeamComponent implements OnInit {
    @Input() public teamSlot: IAvailabilitySlotsGroupByTeamsDto;

    public slots: Array<IAvailabilitySlot>;

    public teamName: string;

    // eslint-disable-next-line no-empty-function
    constructor(public spinnerService: SpinnerService) {}

    ngOnInit(): void {
        this.slots = this.teamSlot.availabilitySlots;
        this.teamName = this.teamSlot.name;
    }
}
