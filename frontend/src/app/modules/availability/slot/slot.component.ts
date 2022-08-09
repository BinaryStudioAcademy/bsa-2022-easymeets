import { Component, Input, OnInit } from '@angular/core';

@Component({
    selector: 'app-slot',
    templateUrl: './slot.component.html',
    styleUrls: ['./slot.component.sass'],
})
export class SlotComponent implements OnInit {
    @Input() public slot: { time: string; user: string; link: string; meetingPlace: string; avatars: Array<string> };

    // eslint-disable-next-line @angular-eslint/no-empty-lifecycle-method
    ngOnInit(): void {}
}
