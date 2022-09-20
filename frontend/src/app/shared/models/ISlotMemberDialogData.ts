import { EventEmitter } from '@angular/core';
import { ISlotMember } from '@core/models/save-availability-slot/ISlotMember';

export interface ISlotMemberDialogData {
    teamId: number;
    alreadySelected: ISlotMember[];
    onAddEvent: EventEmitter<ISlotMember[]>
}
