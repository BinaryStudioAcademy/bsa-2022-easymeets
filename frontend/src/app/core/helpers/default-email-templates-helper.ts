import { TemplateType } from '@core/enums/template-type.enum';
import { ISaveConfirmationEmailDetails } from '@core/models/save-availability-slot/ISaveConfirmationEmailDetails';

export const getDefaultNotificationTemplates = (): ISaveConfirmationEmailDetails[] => [
    {
        allowToSend: true,
        emailSubject: 'Confirmation Email',
        emailBody: `Hi {Invitee Full Name} \r\nYour {Event Name} with {My Name}
        at {Event Time} on {Event Date} is scheduled\r\n{Event Description}\r\n{Location}\r\n{Questions and Answers}`,
        type: TemplateType.Confirmation,
    },
    {
        allowToSend: true,
        emailSubject: 'Cancellation Email',
        emailBody: `Hi {Invitee Full Name} \r\nYour {Event Name} with {My Name}
        at {Event Time} on {Event Date} is unfortunately cancelled`,
        type: TemplateType.Cancellation,
    },
    {
        allowToSend: true,
        emailSubject: 'Reminders Email',
        emailBody: `Hi {Invitee Full Name} \r\nThis is a friendly reminder that your {Event Name} with {My Name} is
        at {Event Time} on {Event Date}\r\n{Event Description}\r\n{Location}\r\n{Questions and Answers}`,
        type: TemplateType.Reminders,
        timeValue: '00:05',
    },
    {
        allowToSend: true,
        emailSubject: 'Follow-Up Email',
        emailBody: `Hi {Invitee Full Name} \r\nThank you for attending {Event Name} on {Event Date}
        \r\nPlease respond to this email with any feedback or additional requests.`,
        type: TemplateType.FollowUp,
        timeValue: '00:05',
    },
];

export const getPathLabel = (type: TemplateType): string => {
    switch (type) {
        case TemplateType.Confirmation:
            return 'Confirmation Email';
        case TemplateType.Cancellation:
            return 'Cancellation Email';
        case TemplateType.Reminders:
            return 'Reminders Email';
        case TemplateType.FollowUp:
            return 'Follow-Up Email';
        default:
            return '';
    }
};
