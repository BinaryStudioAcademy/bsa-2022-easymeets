import { Component, EventEmitter, Input, Output } from '@angular/core';
import { BaseComponent } from '@core/base/base.component';
import { getTeamForMultipleChoice } from '@core/helpers/slot-with-members-multiple-helper';
import { IAvailabilitySlotMember } from '@core/models/IAvailabilitySlotMember';
import { IAvailabilitySlot } from '@core/models/IAvailiabilitySlot';
import { AvailabilitySlotService } from '@core/services/availability-slot.service';

@Component({
    selector: 'app-external-booking-choose-members-page',
    templateUrl: './external-booking-choose-members-page.component.html',
    styleUrls: ['./external-booking-choose-members-page.component.sass'],
})
export class ExternalBookingMembersComponent extends BaseComponent {
    @Input() selectedAvailabilitySlot: IAvailabilitySlot = getTeamForMultipleChoice()[0];

    public selectedTeamMembers: IAvailabilitySlotMember[] = [];

    public checksAreDisabled: boolean;

    @Output() selectedMembersEvent = new EventEmitter<IAvailabilitySlotMember[]>();

    constructor(private availabilitySlotService: AvailabilitySlotService) {
        super();
    }

    public selectMember(member: IAvailabilitySlotMember): void {
        if (this.selectedTeamMembers.includes(member)) {
            const index = this.selectedTeamMembers.findIndex((o) => o.name === member.name);

            this.selectedTeamMembers.splice(index, 1);
        } else {
            this.selectedTeamMembers.push(member);
        }
    }

    public cancelSelection(): void {
        this.selectedTeamMembers.splice(0, this.selectedTeamMembers.length);
        this.checksAreDisabled = false;
    }

    public addMembers(selectedMembers: IAvailabilitySlotMember[]) {
        this.selectedMembersEvent.emit(selectedMembers);
    }
}
