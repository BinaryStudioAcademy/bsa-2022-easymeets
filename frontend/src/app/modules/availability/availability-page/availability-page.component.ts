import { Component } from '@angular/core';
import { IAvailabilitySlot } from '@core/models/IAvailiabilitySlot';
import { IUser } from '@core/models/IUser';
import { IUserPersonalAndTeamSlots } from '@core/models/IUserPersonalAndTeamSlots';
import { AvailabilitySlotService } from '@core/services/availability-slot.service';
import { UserService } from '@core/services/user.service';

@Component({
    selector: 'app-availability-page',
    templateUrl: './availability-page.component.html',
    styleUrls: ['./availability-page.component.sass'],
})
export class AvailabilityPageComponent {
    public userPersonalAndTeamSlots: IUserPersonalAndTeamSlots;

    public currentUser: IUser;

    public userSlots: IAvailabilitySlot[];

    public currentUserId: number = 1;

    constructor(private availabilitySlotService: AvailabilitySlotService, private userService: UserService) {
        this.getCurrentUser();
    }

    public getUserPersonalAndTeamSlots() {
        this.availabilitySlotService
            .getUserPersonalAndTeamSlots(this.currentUser.id)
            .subscribe(
                (resp) => {
                    this.userPersonalAndTeamSlots = resp;
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
