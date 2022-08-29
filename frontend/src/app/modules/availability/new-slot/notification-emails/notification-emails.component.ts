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

    private confirmationSubject = 'Confirmation Email';

    private cancellationSubject = 'Cancellation Email';

    private remindersSubject = 'Reminders Email';

    private followUpSubject = 'Follow-Up Email';

    private body = `Hi {Invitee Full Name} \r\nYou {Event Name} with {My Name} 
    at {Event Time} on {Event Date} is scheduled\r\n{Event Description}\r\n{Location}\r\n{Questions and Answers}`;

    private _defaultSettings: ISaveConfirmationEmailDetails = {
        allowToSend: false,
        type: TemplateType.Confirmation,
        emailBody: this.body,
        emailSubject: this.confirmationSubject,
    };

    public slot?: IAvailabilitySlot;

    public currentSetting?: ISaveConfirmationEmailDetails;

    public settings: ISaveConfirmationEmailDetails;

    public navLinks = [
        { path: 'confirmation', label: this.confirmationSubject },
        { path: 'cancellation', label: this.cancellationSubject },
        { path: 'reminders', label: this.remindersSubject },
        { path: 'follow-up', label: this.followUpSubject },
    ];

    public activeTab = this.navLinks[0].path;

    public changeTemplate(path: string) {
        switch (path) {
            case 'confirmation':
                this.changeTemplateType(TemplateType.Confirmation);
                break;
            case 'cancellation':
                this.changeTemplateType(TemplateType.Cancellation);
                break;
            case 'reminders':
                this.changeTemplateType(TemplateType.Reminders);
                break;
            case 'follow-up':
                this.changeTemplateType(TemplateType.FollowUp);
                break;
            default:
                break;
        }
        this.activeTab = path;
        this.currentSetting = this.slot?.emailTemplateSettings?.find((obj) => obj.type === this.settings.type);
        this.settings = this.currentSetting ?? this._defaultSettings;
    }

    private changeTemplateType(type: TemplateType) {
        this.settings.type = type;
        this._defaultSettings.type = type;
    }
}
