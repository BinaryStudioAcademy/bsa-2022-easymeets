import { Component, Input, OnInit } from '@angular/core';
import { IAvailabilitySlot } from '@core/models/IAvailiabilitySlot';
import { ISaveEventDetails } from '@core/models/save-availability-slot/ISaveEventDetails';

@Component({
    selector: 'app-event-detail',
    templateUrl: './event-detail.component.html',
    styleUrls: ['./event-detail.component.sass'],
})
export class EventDetailComponent implements OnInit {
    @Input() set newSlot(value: IAvailabilitySlot | undefined) {
        this.slot = value;
        this.settings = {
            timeZoneVisibility: this.slot?.timeZoneVisibility ?? false,
            link: this.slot?.link ?? '',
            welcomeMessage: this.slot?.welcomeMessage ?? 'Lorem ipsum dolor sit amet, consectetur adipiscing elit.',
            language: this.slot?.language ?? 'English',
            bookingsPerDay: this.slot?.bookingsPerDay ?? this.allowedBooking[1],
            allowToAddGuests: this.slot?.allowToAddGuests ?? false,
            passwordProtectionIsUsed: this.slot?.passwordProtectionIsUsed ?? false,
            passwordProtection: this.slot?.passwordProtection ?? '',
        };
    }

    public slot?: IAvailabilitySlot;

    public settings: ISaveEventDetails;

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
            timeZoneVisibility: false,
            link: 'heornim',
            welcomeMessage: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit.',
            language: 'English',
            bookingsPerDay: this.allowedBooking[1],
            allowToAddGuests: false,
            passwordProtectionIsUsed: false,
            passwordProtection: '',
        };
    }
}
