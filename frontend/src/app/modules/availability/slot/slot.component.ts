import { Component, Input } from '@angular/core';
import { MatSlideToggleChange } from '@angular/material/slide-toggle';
import { AvailabilitySlot } from '@core/models/availiability-slot';

@Component({
    selector: 'app-slot',
    templateUrl: './slot.component.html',
    styleUrls: ['./slot.component.sass'],
})
export class SlotComponent {
    @Input() public slot: AvailabilitySlot;

    public owner: any;

    public isChecked: boolean = true;

    public toggle(event: MatSlideToggleChange) {
        this.isChecked = event.checked;
    }
}
