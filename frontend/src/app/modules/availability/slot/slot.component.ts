import { Component, Input } from '@angular/core';
import { MatSlideToggleChange } from '@angular/material/slide-toggle';
import { IAvailabilitySlot } from '@core/models/IAvailiabilitySlot';
import { Router } from "@angular/router";

@Component({
    selector: 'app-slot',
    templateUrl: './slot.component.html',
    styleUrls: ['./slot.component.sass'],
})
export class SlotComponent {
    @Input() public slot: IAvailabilitySlot;

    @Input() public hasOwner: boolean;

    public isChecked: boolean = true;

    // eslint-disable-next-line no-empty-function
    constructor(private router: Router) { }

    public toggle(event: MatSlideToggleChange) {
        this.isChecked = event.checked;
    }

    public goToPage(pageName: string) {
        this.router.navigate([`${pageName}`]);
    }
}
