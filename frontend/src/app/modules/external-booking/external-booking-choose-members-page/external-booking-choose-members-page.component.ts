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
            this.selectedTeamMembers = this.selectedTeamMembers.filter((o) => o.name !== member.name);
        } else {
            this.selectedTeamMembers = [...this.selectedTeamMembers, member];
        }
    }

    public cancelSelection(): void {
        this.selectedTeamMembers = [];
        this.checksAreDisabled = false;
    }

    public addMembers(selectedMembers: IAvailabilitySlotMember[]) {
        this.selectedMembersEvent.emit(selectedMembers);
    }
}
