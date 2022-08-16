import { Component, Input } from '@angular/core';
import { IAvailabilitySlot } from '@core/models/IAvailiabilitySlot';
import { IUser } from '@core/models/IUser';
import { AvailabilitySlotService } from '@core/services/availability-slot.service';
import { SpinnerService } from '@core/services/spinner.service';
import { Subject, takeUntil } from 'rxjs';

@Component({
    selector: 'app-user-slot',
    templateUrl: './user-slot.component.html',
    styleUrls: ['./user-slot.component.sass'],
})
export class UserSlotComponent {
    @Input() public userSlots: Array<IAvailabilitySlot>;

    @Input() public currentUser: IUser;

    private unsubscribe$ = new Subject<void>();

    // eslint-disable-next-line no-empty-function
    constructor(public spinnerService: SpinnerService, private availabilitySlotService: AvailabilitySlotService) {}

    public updateUserSlots() {
        this.availabilitySlotService
            .getUserPersonalAndTeamSlots(this.currentUser.id)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe((resp) => {
                this.userSlots = resp.userSlots;
                this.spinnerService.hide();
            });
    }

    isDeleted(isRemove: any) {
        if (isRemove) {
            this.updateUserSlots();
        }
    }
}
