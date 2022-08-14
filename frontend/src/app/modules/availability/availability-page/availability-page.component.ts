import { Component } from '@angular/core';
import { AvailabilitySlotsGroupByTeamsDto } from '@core/models/availability-slots-group-by-team';
import { AvailabilitySlot } from '@core/models/availiability-slot';
import { User } from '@core/models/user';
import { UserPersonalAndTeamSlots } from '@core/models/user-personal-and-team-slots';
import { AvailabilitySlotService } from '@core/services/availability-slot.service';
import { UserService } from '@core/services/user.service';

@Component({
    selector: 'app-availability-page',
    templateUrl: './availability-page.component.html',
    styleUrls: ['./availability-page.component.sass'],
})
export class AvailabilityPageComponent {
    public teamSlots: AvailabilitySlotsGroupByTeamsDto[];

    public userPersonalSlots: AvailabilitySlot[];

    public userPersonalAndTeamSlots: UserPersonalAndTeamSlots;

    public currentUser: User;

    public userSlots: AvailabilitySlot[];

    public currentUserId: number = 4;

    constructor(private availabilitySlotService: AvailabilitySlotService, private userService: UserService) {
        this.getCurrentUser();
    }

    public getUserPersonalAndTeamSlots() {
        this.availabilitySlotService
            .getUserPersonalAndTeamSlots(this.currentUser.id)
            .subscribe(
                (resp) => {
                    this.userPersonalAndTeamSlots = resp;
                    this.teamSlots = this.userPersonalAndTeamSlots.teamSlots;
                    this.userPersonalSlots = this.userPersonalAndTeamSlots.userSlots;
                },
            );
    }

    public getCurrentUser() {
        this.userService
            .getCurrentUserById(this.currentUserId)
            .subscribe(
                (resp) => {
                    if (resp) {
                        this.currentUser = resp;
                        this.getUserPersonalAndTeamSlots();
                    }
                },
            );
    }
}
