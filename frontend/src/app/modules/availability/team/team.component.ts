import { Component, Input, OnInit } from '@angular/core';
import { IAvailabilitySlotsGroupByTeamsDto } from '@core/models/IAvailabilitySlotsGroupByTeam';
import { IAvailabilitySlot } from '@core/models/IAvailiabilitySlot';
import { IUser } from '@core/models/IUser';
import { AvailabilitySlotService } from '@core/services/availability-slot.service';
import { SpinnerService } from '@core/services/spinner.service';
import { Subject, takeUntil } from 'rxjs';

@Component({
    selector: 'app-team',
    templateUrl: './team.component.html',
    styleUrls: ['./team.component.sass'],
})
export class TeamComponent implements OnInit {
    @Input() public teamSlot: IAvailabilitySlotsGroupByTeamsDto;

    @Input() public currentUser: IUser;

    public slots: Array<IAvailabilitySlot>;

    private unsubscribe$ = new Subject<void>();

    public teamName: string;

    // eslint-disable-next-line no-empty-function
    constructor(public spinnerService: SpinnerService, private availabilitySlotService: AvailabilitySlotService) {}

    ngOnInit(): void {
        this.slots = this.teamSlot.availabilitySlots;
        this.teamName = this.teamSlot.name;
    }

    public updateTeamsSlots() {
        this.availabilitySlotService
            .getUserPersonalAndTeamSlots(this.currentUser.id)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe((resp) => {
                const [teamSlots] = resp.teamSlots.filter((el) => el.name === this.teamName);

                this.slots = teamSlots.availabilitySlots;
                this.spinnerService.hide();
            });
    }

    isDeleted(isRemove: any) {
        if (isRemove) {
            this.updateTeamsSlots();
        }
    }
}
