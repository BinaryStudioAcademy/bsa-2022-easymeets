import { Component } from '@angular/core';
import { BaseComponent } from '@core/base/base.component';
import { IAvailabilitySlot } from '@core/models/IAvailiabilitySlot';
import { ILocalUser } from '@core/models/IUser';
import { IUserPersonalAndTeamSlots } from '@core/models/IUserPersonalAndTeamSlots';
import { AvailabilitySlotService } from '@core/services/availability-slot.service';
import { SpinnerService } from '@core/services/spinner.service';
import { UserService } from '@core/services/user.service';

@Component({
    selector: 'app-availability-page',
    templateUrl: './availability-page.component.html',
    styleUrls: ['./availability-page.component.sass'],
})
export class AvailabilityPageComponent extends BaseComponent {
    public userPersonalAndTeamSlots: IUserPersonalAndTeamSlots;

    public currentUser: ILocalUser;

    public userSlots: IAvailabilitySlot[];

    constructor(
        private userService: UserService,
        private availabilitySlotService: AvailabilitySlotService,
        private spinnerService: SpinnerService,
    ) {
        super();
        this.getCurrentUser();
    }

    public getUserPersonalAndTeamSlots() {
        this.availabilitySlotService
            .getUserPersonalAndTeamSlots(this.currentUser.id)
            .pipe(this.untilThis)
            .subscribe((resp) => {
                this.userPersonalAndTeamSlots = resp;
                this.spinnerService.hide();
            });
    }

    public getCurrentUser() {
        this.spinnerService.show();
        this.currentUser = this.userService.getUserFromStorage();
        this.getUserPersonalAndTeamSlots();
    }

    reloadData(isReload: boolean) {
        if (isReload) {
            this.getUserPersonalAndTeamSlots();
        }
    }
}
