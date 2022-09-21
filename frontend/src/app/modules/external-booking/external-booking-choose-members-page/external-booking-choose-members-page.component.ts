import { Component, EventEmitter, Input, Output } from '@angular/core';
import { BaseComponent } from '@core/base/base.component';
import { ISlotMember } from '@core/models/save-availability-slot/ISlotMember';

@Component({
    selector: 'app-external-booking-choose-members-page',
    templateUrl: './external-booking-choose-members-page.component.html',
    styleUrls: ['./external-booking-choose-members-page.component.sass'],
})
export class ExternalBookingMembersComponent extends BaseComponent {
    @Input() public slotMembers?: ISlotMember[] = [];

    @Output() selectedMemberEvent = new EventEmitter<ISlotMember>();

    public selectMember(member: ISlotMember): void {
        this.selectedMemberEvent.emit(member);
    }
}
