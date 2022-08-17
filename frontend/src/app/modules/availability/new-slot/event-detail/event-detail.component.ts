import { Component, Input, OnInit } from '@angular/core';
import { IAvailabilitySlot } from '@core/models/IAvailiabilitySlot';
import { IEventDetailSettings } from '@core/models/IEventDetailSettings';

@Component({
    selector: 'app-event-detail',
    templateUrl: './event-detail.component.html',
    styleUrls: ['./event-detail.component.sass'],
})
export class EventDetailComponent implements OnInit {
    @Input() set newSlot(value: IAvailabilitySlot | undefined) {
        this.slot = value;
        this.settings = {
            zoneChoice: this.slot?.timeZoneVisibility ?? false,
            linkChoice: this.slot?.link ?? '',
            welcomeMessage: this.slot?.welcomeMessage ?? 'Lorem ipsum dolor sit amet, consectetur adipiscing elit.',
            languageSelect: this.slot?.language ?? 'English',
            allowBookingSelect: this.slot?.bookingsPerDay ?? this.allowedBooking[1],
            isAllowBooker: this.slot?.allowToAddGuests ?? false,
            passwordProtect: this.slot?.passwordProtectionIsUsed ?? false,
            passwordInput: this.slot?.passwordProtection ?? '',
        };
    }

    public slot?: IAvailabilitySlot;

    public settings: IEventDetailSettings;

    public timeZoneChoices: { text: string; value: boolean; }[] = [
        {
            text: 'Automatically detect and show the times in Bookers time zone',
            value: true,
        },
        {
            text: 'Lock the timezone (best for in-person events)',
            value: false,
        },
    ];

    public languages: string[] = [
        'English',
        'Ukrainian',
    ];

    public allowedBooking: number[] = [
        1,
        2,
        3,
    ];

    ngOnInit(): void {
        this.settings = {
            zoneChoice: false,
            linkChoice: 'heornim',
            welcomeMessage: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit.',
            languageSelect: 'English',
            allowBookingSelect: this.allowedBooking[1],
            isAllowBooker: false,
            passwordProtect: false,
            passwordInput: '',
        };
    }
}
