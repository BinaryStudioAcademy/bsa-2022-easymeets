import { Component, Input } from '@angular/core';
import { MatSlideToggleChange } from '@angular/material/slide-toggle';

@Component({
    selector: 'app-slot',
    templateUrl: './slot.component.html',
    styleUrls: ['./slot.component.sass'],
})
export class SlotComponent {
    @Input() public slot: {
        time: string;
        user: string;
        link: string;
        meetingPlace: string;
        avatars: Array<string>;
    };

    public isChecked: boolean = true;

    public isDisabled: boolean = false;

    public toggle(event: MatSlideToggleChange) {
        this.isChecked = event.checked;
    }
}
