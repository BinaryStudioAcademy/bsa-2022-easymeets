import { Component, Input, OnInit } from '@angular/core';
import { IAvailabilitySlot } from '@core/models/IAvailiabilitySlot';

@Component({
    selector: 'app-notification-emails',
    templateUrl: './notification-emails.component.html',
    styleUrls: ['./notification-emails.component.sass'],
})
export class NotificationEmailsComponent implements OnInit {
    @Input() set newSlot(value: IAvailabilitySlot | undefined) {
        this.slot = value;
    }

    public slot?: IAvailabilitySlot;

    public navLinks = [
        { path: '', label: 'Confirmation Email' },
        { path: ' ', label: 'Cancellation Email' },
        { path: ' ', label: 'Email Reminders' },
        { path: ' ', label: 'Email Follow-Up' },
    ];

    public activeTab = this.navLinks[0].label;

    // eslint-disable-next-line @angular-eslint/no-empty-lifecycle-method
    ngOnInit(): void {}
}
