import { Component } from '@angular/core';
import { BaseComponent } from '@core/base/base.component';
import { IAvailabilitySlot } from '@core/models/IAvailiabilitySlot';
import { IUser } from '@core/models/IUser';
import { IUserPersonalAndTeamSlots } from '@core/models/IUserPersonalAndTeamSlots';
import { AvailabilitySlotService } from '@core/services/availability-slot.service';
import { SpinnerService } from '@core/services/spinner.service';

@Component({
    selector: 'app-availability-page',
    templateUrl: './availability-page.component.html',
    styleUrls: ['./availability-page.component.sass'],
})
export class AvailabilityPageComponent extends BaseComponent {
    public userPersonalAndTeamSlots: IUserPersonalAndTeamSlots;

    public currentUser: IUser;

    public userSlots: IAvailabilitySlot[];

    constructor(private availabilitySlotService: AvailabilitySlotService, private spinnerService: SpinnerService) {
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
        const user = localStorage.getItem('user');

        this.currentUser = JSON.parse(user!) as IUser;
        this.getUserPersonalAndTeamSlots();
    }

    reloadData(isReload: boolean) {
        if (isReload) {
            this.getUserPersonalAndTeamSlots();
        }
    }
}
