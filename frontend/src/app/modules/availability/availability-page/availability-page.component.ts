import { Component } from '@angular/core';
import { BaseComponent } from '@core/base/base.component';
import { IAvailabilitySlot } from '@core/models/IAvailabilitySlot';
import { IUser } from '@core/models/IUser';
import { IUserPersonalAndTeamSlots } from '@core/models/IUserPersonalAndTeamSlots';
import { AvailabilitySlotService } from '@core/services/availability-slot.service';
import { SpinnerService } from '@core/services/spinner.service';
import { TeamService } from '@core/services/team.service';
import { UserService } from '@core/services/user.service';

@Component({
    selector: 'app-availability-page',
    templateUrl: './availability-page.component.html',
    styleUrls: ['./availability-page.component.sass'],
})
export class AvailabilityPageComponent extends BaseComponent {
    public userPersonalAndTeamSlots: IUserPersonalAndTeamSlots;

    public currentUser: IUser;

    public userSlots: IAvailabilitySlot[];

    constructor(
        private userService: UserService,
        private availabilitySlotService: AvailabilitySlotService,
        private spinnerService: SpinnerService,
        private teamService: TeamService,
    ) {
        super();
        this.getCurrentUser();
    }

    public getUserPersonalAndTeamSlots(teamId?: number) {
        this.availabilitySlotService
            .getUserPersonalAndTeamSlots(this.currentUser.id, teamId)
            .pipe(this.untilThis)
            .subscribe((resp) => {
                this.userPersonalAndTeamSlots = resp;
                this.spinnerService.hide();
            });
    }

    public getCurrentUser() {
        this.spinnerService.show();
        this.userService
            .getCurrentUser()
            .pipe(this.untilThis)
            .subscribe((resp) => {
                if (resp) {
                    this.currentUser = resp;
                    this.getUserPersonalAndTeamSlots();
                    this.teamService.currentTeamEmitted$.pipe(this.untilThis).subscribe((teamId) => {
                        this.getUserPersonalAndTeamSlots(teamId);
                    });
                }
            });
    }

    reloadData(isReload: boolean) {
        if (isReload) {
            this.getUserPersonalAndTeamSlots();
        }
    }
}
