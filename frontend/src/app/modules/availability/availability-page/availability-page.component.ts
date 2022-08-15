import { Component } from '@angular/core';
import { IAvailabilitySlot } from '@core/models/IAvailiabilitySlot';
import { IUser } from '@core/models/IUser';
import { IUserPersonalAndTeamSlots } from '@core/models/IUserPersonalAndTeamSlots';
import { AvailabilitySlotService } from '@core/services/availability-slot.service';
import { SpinnerService } from '@core/services/spinner.service';
import { UserService } from '@core/services/user.service';
import { Subject, takeUntil } from 'rxjs';

@Component({
    selector: 'app-availability-page',
    templateUrl: './availability-page.component.html',
    styleUrls: ['./availability-page.component.sass'],
})
export class AvailabilityPageComponent {
    public userPersonalAndTeamSlots: IUserPersonalAndTeamSlots;

    public currentUser: IUser;

    public userSlots: IAvailabilitySlot[];

    public currentUserId: number = 2;

    private unsubscribe$ = new Subject<void>();

    constructor(
        private availabilitySlotService: AvailabilitySlotService,
        private userService: UserService,
        private spinnerService: SpinnerService,
    ) {
        this.getCurrentUser();
    }

    public getUserPersonalAndTeamSlots() {
        this.availabilitySlotService
            .getUserPersonalAndTeamSlots(this.currentUser.id)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe(
                (resp) => {
                    this.userPersonalAndTeamSlots = resp;
                    this.spinnerService.hide();
                },
            );
    }

    public getCurrentUser() {
        this.spinnerService.show();
        this.userService
            .getCurrentUserById(this.currentUserId)
            .pipe(takeUntil(this.unsubscribe$))
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
