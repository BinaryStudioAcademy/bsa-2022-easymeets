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

    languages: string[] = [
        'English',
        'Ukrainian',
    ];

    allowedBooking: string[] = [
        '1',
        '2',
        '3',
    ];

    public zoneChoice: string;

    public linkChoice: string = 'heorhim';

    public welcomeMessage: string = 'Lorem ipsum dolor sit amet, consectetur adipiscing elit.';

    public languageSelect: string = 'English';

    public allowBookingSelect: string = '2';

    public isAllowBooker: boolean;

    public basicChoice: boolean = true;

    public passwordProtect: boolean = true;

    public passwordInput: string = 'Meeting123';
}
