import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { IAvailabilitySlot } from '@core/models/IAvailabilitySlot';
import { IAvailabilitySlotsGroupByTeamsDto } from '@core/models/IAvailabilitySlotsGroupByTeam';

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
