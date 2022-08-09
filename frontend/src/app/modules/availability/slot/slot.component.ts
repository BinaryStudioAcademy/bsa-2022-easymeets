import { Component, Input, OnInit } from '@angular/core';
import { MatSlideToggleChange } from '@angular/material/slide-toggle';

@Component({
    selector: 'app-slot',
    templateUrl: './slot.component.html',
    styleUrls: ['./slot.component.sass'],
})
export class SlotComponent implements OnInit {
    @Input() public slot: {
        time: string;
        user: string;
        link: string;
        meetingPlace: string;
        avatars: Array<string>;
    };

    public isChecked: boolean = true;

    public isDisabled: boolean = false;

    // eslint-disable-next-line @angular-eslint/no-empty-lifecycle-method
    ngOnInit(): void {}

    public toggle(event: MatSlideToggleChange) {
        console.log('toggle', event.checked);
        this.isChecked = event.checked;
    }
}
