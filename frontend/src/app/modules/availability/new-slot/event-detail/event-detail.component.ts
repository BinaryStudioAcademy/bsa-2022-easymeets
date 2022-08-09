import { Component } from '@angular/core';

@Component({
    selector: 'app-event-detail',
    templateUrl: './event-detail.component.html',
    styleUrls: ['./event-detail.component.sass'],
})
export class EventDetailComponent {
    timeZoneChoices: string[] = [
        'Automatically detect and show the times in Bookers time zone',
        'Lock the timezone (best for in-person events)',
    ];

    zoneChoice: string;

    linkChoice: string;

    welcomeMessage: string;
}
