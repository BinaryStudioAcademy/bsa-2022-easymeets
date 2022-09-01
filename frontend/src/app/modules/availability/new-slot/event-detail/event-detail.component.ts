import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { IAvailabilitySlot } from '@core/models/IAvailabilitySlot';
import { ISaveEventDetails } from '@core/models/save-availability-slot/ISaveEventDetails';
import { environment } from '@env/environment';

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

    @Output() linkChange = new EventEmitter<string>();

    public appDomain = environment.appUrl;

    public slot?: IAvailabilitySlot;

    public settings: ISaveEventDetails;

    public timeZoneChoices: { text: string; value: boolean }[] = [
        {
            text: 'Automatically detect and show the times in Bookers time zone',
            value: true,
        },
        {
            text: 'Lock the timezone (best for in-person events)',
            value: false,
        },
    ];

    public languages: string[] = ['English', 'Ukrainian'];

    public allowedBooking: number[] = [1, 2, 3];

    public hidePassword: boolean = false;

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

    onLinkChange() {
        this.linkChange.emit(this.settings.link);
    }
}
