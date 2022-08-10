import { Component, Input } from '@angular/core';
import { MatSlideToggleChange } from '@angular/material/slide-toggle';
import { Slot } from '@core/interfaces/slot-interface';

@Component({
    selector: 'app-slot',
    templateUrl: './slot.component.html',
    styleUrls: ['./slot.component.sass'],
})
export class SlotComponent {
    @Input() public slot: Slot;

    public isChecked: boolean = true;

    public isDisabled: boolean = false;

    public toggle(event: MatSlideToggleChange) {
        this.isChecked = event.checked;
    }
}
