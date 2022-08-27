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
        this.confirmationSetting = this.slot?.confirmationEmailSettings?.find(
            (obj) => obj.type === TemplateType.Confirmation,
        );
        this.settings = this.confirmationSetting ?? {
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

    private _body =
        // eslint-disable-next-line max-len
        'Hi {Invitee Full Name} \r\nYou {Event Name} with {My Name} at {Event Time} on {Event Date} is scheduled\r\n{Event Description}\r\n{Location}\r\n{Questions and Answers}';

    public slot?: IAvailabilitySlot;

    public confirmationSetting?: ISaveConfirmationEmailDetails;

    public settings: ISaveConfirmationEmailDetails;

    public navLinks = [
        { path: 'confirmation', label: this._confirmationSubject },
        { path: 'cancellation', label: this._cancellationSubject },
        { path: 'reminders', label: this._remindersSubject },
        { path: 'follow-up', label: this._followUpSubject },
    ];

    public activeTab = this.navLinks[0].path;

    public changeTemplate(path: string) {
        if (path === 'confirmation') {
            this.activeTab = path;

            this.settings.emailSubject = this.confirmationSetting?.emailSubject ?? this._confirmationSubject;
            this.settings.type = TemplateType.Confirmation;
            this.settings.emailBody = this.confirmationSetting?.emailBody ?? this._body;
        }
        if (path === 'cancellation') {
            this.activeTab = path;
            const cancellationSetting = this.slot?.confirmationEmailSettings?.find(
                (obj) => obj.type === TemplateType.Cancellation,
            );

            this.settings.emailSubject = cancellationSetting?.emailSubject ?? this._cancellationSubject;
            this.settings.type = TemplateType.Cancellation;
            this.settings.emailBody = cancellationSetting?.emailBody ?? this._body;
        }
        if (path === 'reminders') {
            this.activeTab = path;
            const reminderSetting = this.slot?.confirmationEmailSettings?.find(
                (obj) => obj.type === TemplateType.Reminders,
            );

            this.settings.emailSubject = reminderSetting?.emailSubject ?? this._remindersSubject;
            this.settings.type = TemplateType.Reminders;
            this.settings.emailBody = reminderSetting?.emailBody ?? this._body;
        }
        if (path === 'follow-up') {
            this.activeTab = path;
            const followUpSetting = this.slot?.confirmationEmailSettings?.find(
                (obj) => obj.type === TemplateType.FollowUp,
            );

            this.settings.emailSubject = followUpSetting?.emailSubject ?? this._followUpSubject;
            this.settings.type = TemplateType.FollowUp;
            this.settings.emailBody = followUpSetting?.emailBody ?? this._body;
        }
    }
}
