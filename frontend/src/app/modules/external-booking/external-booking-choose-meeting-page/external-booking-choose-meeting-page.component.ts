import { Component, Input, OnInit } from '@angular/core';
import { BaseComponent } from '@core/base/base.component';
import { LocationTypeMapping } from '@core/helpers/location-type-mapping';
import { IUserPersonalAndTeamSlots } from '@core/models/IUserPersonalAndTeamSlots';
import { AvailabilitySlotService } from '@core/services/availability-slot.service';
import { SpinnerService } from '@core/services/spinner.service';
import { TeamService } from '@core/services/team.service';

@Component({
    selector: 'app-external-booking-choose-meeting-page',
    templateUrl: './external-booking-choose-meeting-page.component.html',
    styleUrls: ['./external-booking-choose-meeting-page.component.sass'],
})
export class ExternalBookingMeetingComponent extends BaseComponent implements OnInit {
    @Input() userId: bigint;

    teamId?: number;

    selectedUserAvailabilitySlots: IUserPersonalAndTeamSlots;

    locationTypeMapping = LocationTypeMapping;

    constructor(
        public spinnerService: SpinnerService,
        private teamService: TeamService,
        private availabilitySlotService: AvailabilitySlotService,
    ) {
        super();
    }

    ngOnInit(): void {
        this.teamService.currentTeamEmitted$.pipe(this.untilThis).subscribe((teamId) => {
            this.teamId = teamId;
            this.downloadSlots();
        });
    }

    downloadSlots() {
        this.availabilitySlotService
            .getUserPersonalAndTeamSlots(this.userId, this.teamId)
            .pipe(this.untilThis)
            .subscribe((resp) => {
                this.selectedUserAvailabilitySlots = resp;
                this.spinnerService.hide();
            });
    }
}
