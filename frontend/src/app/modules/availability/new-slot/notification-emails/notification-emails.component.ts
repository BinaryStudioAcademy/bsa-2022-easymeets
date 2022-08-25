import { Component, Input, OnInit } from '@angular/core';
import { IAvailabilitySlot } from '@core/models/IAvailiabilitySlot';
import { ISaveConfirmationEmailDetails } from '@core/models/save-availability-slot/ISaveConfirmationEmailDetails';

@Component({
    selector: 'app-notification-emails',
    templateUrl: './notification-emails.component.html',
    styleUrls: ['./notification-emails.component.sass'],
})
export class NotificationEmailsComponent implements OnInit {
    @Input() set newSlot(value: IAvailabilitySlot | undefined) {
        this.slot = value;
        this.settings = {
            allowToSend: this.slot?.confirmationEmailSettings?.allowToSend ?? false,
            emailSubject: this.slot?.confirmationEmailSettings?.emailSubject ?? '',
            emailBody: this.slot?.confirmationEmailSettings?.emailBody ?? '',
        };
    }

    public slot?: IAvailabilitySlot;

    public settings: ISaveConfirmationEmailDetails;

    public navLinks = [
        { path: '', label: 'Confirmation Email' },
        { path: ' ', label: 'Cancellation Email' },
        { path: ' ', label: 'Email Reminders' },
        { path: ' ', label: 'Email Follow-Up' },
    ];

    public activeTab = this.navLinks[0].label;

    ngOnInit(): void {
        this.settings = {
            allowToSend: this.slot?.confirmationEmailSettings?.allowToSend ?? true,
            emailSubject: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit.',
            emailBody:
                'Lorem ipsum dolor sit amet. Lorem ipsum dolor, consectetur adipiscing elit. Lorem amet, consectetur adipiscing elit.',
        };
    }
}
