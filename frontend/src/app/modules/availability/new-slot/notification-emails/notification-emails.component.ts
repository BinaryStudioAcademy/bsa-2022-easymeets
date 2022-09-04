/* eslint-disable indent */
import { Component, Input } from '@angular/core';
import { TemplateType } from '@core/enums/template-type.enum';
import { getNotificationTemplate } from '@core/helpers/notification-templates';
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

    private _defaultSettings: ISaveConfirmationEmailDetails = {
        allowToSend: false,
        type: TemplateType.Confirmation,
        emailBody: getNotificationTemplate(TemplateType.Confirmation)?.body,
        emailSubject: getNotificationTemplate(TemplateType.Confirmation)?.label,
    };

    public slot?: IAvailabilitySlot;

    public currentSetting?: ISaveConfirmationEmailDetails;

    public settings: ISaveConfirmationEmailDetails;

    public navLinks = [
        { path: 'confirmation', label: getNotificationTemplate(TemplateType.Confirmation)?.label },
        { path: 'cancellation', label: getNotificationTemplate(TemplateType.Cancellation)?.label },
        { path: 'reminders', label: getNotificationTemplate(TemplateType.Reminders)?.label },
        { path: 'follow-up', label: getNotificationTemplate(TemplateType.FollowUp)?.label },
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
        this.settings.emailSubject = getNotificationTemplate(type)?.label;
        this.settings.emailBody = getNotificationTemplate(type)?.body;
    }
}
