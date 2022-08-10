import { Component, OnInit } from '@angular/core';
import { IEventDetailSettings } from '@core/models/IEventDetailSettings';

@Component({
    selector: 'app-event-detail',
    templateUrl: './event-detail.component.html',
    styleUrls: ['./event-detail.component.sass'],
})
export class EventDetailComponent implements OnInit {
    public settings: IEventDetailSettings;

    public timeZoneChoices: string[] = [
        'Automatically detect and show the times in Bookers time zone',
        'Lock the timezone (best for in-person events)',
    ];

    public languages: string[] = [
        'English',
        'Ukrainian',
    ];

    public allowedBooking: string[] = [
        '1',
        '2',
        '3',
    ];

    ngOnInit(): void {
        this.settings = {
            zoneChoice: '',
            linkChoice: 'heornim',
            welcomeMessage: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit.',
            languageSelect: 'English',
            allowBookingSelect: '2',
            isAllowBooker: false,
            basicChoice: true,
            passwordProtect: true,
            passwordInput: 'Meeting123',
        };
    }
}
