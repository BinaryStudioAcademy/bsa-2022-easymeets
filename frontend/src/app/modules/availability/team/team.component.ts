import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Router } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { IAvailabilitySlot } from '@core/models/IAvailabilitySlot';
import { IAvailabilitySlotsGroupByTeamsDto } from '@core/models/IAvailabilitySlotsGroupByTeam';

@Component({
    selector: 'app-team',
    templateUrl: './team.component.html',
    styleUrls: ['./team.component.sass'],
})
export class TeamComponent extends BaseComponent implements OnInit {
    @Input() public teamSlot: IAvailabilitySlotsGroupByTeamsDto;

    @Output() isReload = new EventEmitter<boolean>();

    public slots: Array<IAvailabilitySlot>;

    public teamName: string;

    constructor(private router: Router) {
        super();
    }

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

    goToPage(teamId: bigint) {
        this.router.navigate([`settings/teams/edit/${teamId}`]);
    }
}
