/* eslint-disable indent */
import { Component, Input } from '@angular/core';
import { TemplateType } from '@core/enums/template-type.enum';
import { IAvailabilitySlot } from '@core/models/IAvailabilitySlot';
import { ISaveConfirmationEmailDetails } from '@core/models/save-availability-slot/ISaveConfirmationEmailDetails';

@Component({
    selector: 'app-notification-emails',
    templateUrl: './notification-emails.component.html',
    styleUrls: ['./notification-emails.component.sass'],
})
export class NotificationEmailsComponent {
    @Input() set newSlot(value: IAvailabilitySlot | undefined) {
        this.slot = value;
        this.settings =
            this.slot?.emailTemplateSettings?.find((obj) => obj.type === TemplateType.Confirmation) ??
            this._defaultSettings;
    }

    private _confirmationSubject = 'Confirmation Email';

    private _cancellationSubject = 'Cancellation Email';

    private _remindersSubject = 'Reminders Email';

    private _followUpSubject = 'Follow-Up Email';

    private _body = `Hi {Invitee Full Name} \r\nYou {Event Name} with {My Name} 
    at {Event Time} on {Event Date} is scheduled\r\n{Event Description}\r\n{Location}\r\n{Questions and Answers}`;

    private _defaultSettings: ISaveConfirmationEmailDetails = {
        allowToSend: false,
        type: TemplateType.Confirmation,
        emailBody: this._body,
        emailSubject: this._confirmationSubject,
    };

    public slot?: IAvailabilitySlot;

    public currentSetting?: ISaveConfirmationEmailDetails;

    public settings: ISaveConfirmationEmailDetails;

    public navLinks = [
        { path: 'confirmation', label: this._confirmationSubject },
        { path: 'cancellation', label: this._cancellationSubject },
        { path: 'reminders', label: this._remindersSubject },
        { path: 'follow-up', label: this._followUpSubject },
    ];

    public activeTab = this.navLinks[0].path;

    public changeTemplate(path: string) {
        switch (path) {
            case 'confirmation':
                this.settings.type = TemplateType.Confirmation;
                this._defaultSettings.type = TemplateType.Confirmation;
                break;
            case 'cancellation':
                this.settings.type = TemplateType.Cancellation;
                this._defaultSettings.type = TemplateType.Cancellation;
                break;
            case 'reminders':
                this.settings.type = TemplateType.Reminders;
                this._defaultSettings.type = TemplateType.Reminders;
                break;
            case 'follow-up':
                this.settings.type = TemplateType.FollowUp;
                this._defaultSettings.type = TemplateType.FollowUp;
                break;
            default:
                break;
        }
        this.activeTab = path;
        this.currentSetting = this.slot?.emailTemplateSettings?.find((obj) => obj.type === this.settings.type);
        this.settings = this.currentSetting ?? this._defaultSettings;
    }
}
