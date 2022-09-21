/* eslint-disable indent */
import { Component, Input } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { TemplateType } from '@core/enums/template-type.enum';
import { getDefaultNotificationTemplates, getPathLabel } from '@core/helpers/default-email-templates-helper';
import { IAvailabilitySlot } from '@core/models/IAvailabilitySlot';
import { ISaveConfirmationEmailDetails } from '@core/models/save-availability-slot/ISaveConfirmationEmailDetails';
import { hourMinutesRegex } from '@shared/constants/model-validation';

@Component({
    selector: 'app-notification-emails',
    templateUrl: './notification-emails.component.html',
    styleUrls: ['./notification-emails.component.sass'],
})
export class NotificationEmailsComponent {
    @Input() set newSlot(value: IAvailabilitySlot | undefined) {
        this.slot = value;
        this.settings = this.slot?.emailTemplateSettings ?? getDefaultNotificationTemplates();
    }

    public templateIndex: number = 0;

    public slot?: IAvailabilitySlot;

    public settings: ISaveConfirmationEmailDetails[];

    public navLinks = [
        { path: 'confirmation', label: getPathLabel(TemplateType.Confirmation) },
        { path: 'cancellation', label: getPathLabel(TemplateType.Cancellation) },
        { path: 'reminders', label: getPathLabel(TemplateType.Reminders) },
        { path: 'follow-up', label: getPathLabel(TemplateType.FollowUp) },
    ];

    public activeTab = this.navLinks[0].path;

    scheduleForm = new FormGroup({
        startTime: new FormControl('00:05', [Validators.pattern(hourMinutesRegex), Validators.required]),
    });

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
    }

    private changeTemplateType(type: TemplateType) {
        const template = this.settings.find((el) => el.type === type);

        if (template) {
            this.templateIndex = this.settings.indexOf(template);
        }
    }

    get startTime() {
        return this.scheduleForm.get('startTime');
    }
}
