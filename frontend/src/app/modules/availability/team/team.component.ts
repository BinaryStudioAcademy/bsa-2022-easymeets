import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { IAvailabilitySlot } from '@core/models/IAvailabilitySlot';
import { IAvailabilitySlotsGroupByTeamsDto } from '@core/models/IAvailabilitySlotsGroupByTeam';
import { SpinnerService } from '@core/services/spinner.service';

@Component({
    selector: 'app-team',
    templateUrl: './team.component.html',
    styleUrls: ['./team.component.sass'],
})
export class TeamComponent implements OnInit {
    @Input() public teamSlot: IAvailabilitySlotsGroupByTeamsDto;

    @Output() isReload = new EventEmitter<boolean>();

    public slots: Array<IAvailabilitySlot>;

    public teamName: string;

    // eslint-disable-next-line no-empty-function
    constructor(public spinnerService: SpinnerService) {}

    ngOnInit(): void {
        this.slots = this.teamSlot.availabilitySlots;
        this.teamName = this.teamSlot.name;
    }

    isDeleted(isRemove: boolean) {
        this.isReload.emit(isRemove);
    }

    isChangedActivity(isChanged: boolean) {
        this.isReload.emit(isChanged);
    }
}
