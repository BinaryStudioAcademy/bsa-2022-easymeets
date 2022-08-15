import { Component, Input } from '@angular/core';
import { MatSlideToggleChange } from '@angular/material/slide-toggle';
import { IAvailabilitySlot } from '@core/models/IAvailiabilitySlot';

@Component({
    selector: 'app-slot',
    templateUrl: './slot.component.html',
    styleUrls: ['./slot.component.sass'],
})
export class SlotComponent {
    @Input() public slot: IAvailabilitySlot;

    @Input() public hasOwner: boolean;

    public isChecked: boolean = true;

    public toggle(event: MatSlideToggleChange) {
        this.isChecked = event.checked;
    }
}
