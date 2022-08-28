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
        this.currentSetting = this.slot?.emailTemplateSettings?.find((obj) => obj.type === TemplateType.Confirmation);
        this.settings = this.currentSetting ?? {
            allowToSend: false,
            emailSubject: this._confirmationSubject,
            emailBody: this._body,
            type: TemplateType.Confirmation,
        };
    }

    private _confirmationSubject = 'Confirmation Email';

    private _cancellationSubject = 'Cancellation Email';

    private _remindersSubject = 'Reminders Email';

    private _followUpSubject = 'Follow-Up Email';

    private _body = `Hi {Invitee Full Name} \r\nYou {Event Name} with {My Name} 
    at {Event Time} on {Event Date} is scheduled\r\n{Event Description}\r\n{Location}\r\n{Questions and Answers}`;

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
                this.currentSetting = this.slot?.emailTemplateSettings?.find(
                    (obj) => obj.type === TemplateType.Confirmation,
                );
                this.settings.type = TemplateType.Confirmation;
                break;
            case 'cancellation':
                this.currentSetting = this.slot?.emailTemplateSettings?.find(
                    (obj) => obj.type === TemplateType.Cancellation,
                );
                this.settings.type = TemplateType.Cancellation;
                break;
            case 'reminders':
                this.currentSetting = this.slot?.emailTemplateSettings?.find(
                    (obj) => obj.type === TemplateType.Reminders,
                );
                this.settings.type = TemplateType.Reminders;
                break;
            case 'follow-up':
                this.currentSetting = this.slot?.emailTemplateSettings?.find(
                    (obj) => obj.type === TemplateType.Reminders,
                );
                this.settings.type = TemplateType.Reminders;
                break;
            default:
                break;
        }
        this.activeTab = path;
        this.settings.emailSubject = this.currentSetting?.emailSubject ?? this._confirmationSubject;
        this.settings.emailBody = this.currentSetting?.emailBody ?? this._body;
    }
}
