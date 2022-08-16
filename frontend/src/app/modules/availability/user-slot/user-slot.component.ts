import { Component, Input } from '@angular/core';
import { IAvailabilitySlot } from '@core/models/IAvailiabilitySlot';
import { IUser } from '@core/models/IUser';
import { IUserPersonalAndTeamSlots } from '@core/models/IUserPersonalAndTeamSlots';
import { AvailabilitySlotService } from '@core/services/availability-slot.service';
import { SpinnerService } from '@core/services/spinner.service';
import { Observable, Subject, takeUntil } from 'rxjs';

@Component({
    selector: 'app-user-slot',
    templateUrl: './user-slot.component.html',
    styleUrls: ['./user-slot.component.sass'],
})
export class UserSlotComponent {
    public userPersonalAndTeamSlots: IUserPersonalAndTeamSlots;

    @Input() public userSlots: Array<IAvailabilitySlot>;

    @Input() public currentUser: IUser;

    protected destroyed$ = new Subject<void>();

    readonly untilThis = <T>(source: Observable<T>) => source.pipe(takeUntil(this.destroyed$));

    // eslint-disable-next-line no-empty-function
    constructor(public spinnerService: SpinnerService, private availabilitySlotService: AvailabilitySlotService) {}

    public updateUserSlots() {
        this.availabilitySlotService
            .getUserPersonalAndTeamSlots(this.currentUser.id)
            .pipe(this.untilThis)
            .subscribe((resp) => {
                this.userPersonalAndTeamSlots = resp;
                this.userSlots = this.userPersonalAndTeamSlots.userSlots;
                this.spinnerService.hide();
            });
    }

    isDeleted(isRemove: any) {
        if (isRemove) {
            this.updateUserSlots();
        }
    }
}
