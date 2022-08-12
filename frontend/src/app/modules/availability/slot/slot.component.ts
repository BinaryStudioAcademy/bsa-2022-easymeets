import { Component, Input } from '@angular/core';
import { MatSlideToggleChange } from '@angular/material/slide-toggle';
import { Router } from '@angular/router';
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

    // eslint-disable-next-line no-empty-function
    constructor(private router: Router) { }

    public toggle(event: MatSlideToggleChange) {
        this.isChecked = event.checked;
    }

    public goToPage(pageName: string) {
        this.router.navigate([`${pageName}`]);
    }
}
