import { TemplateType } from '@core/enums/template-type.enum';
import { INotificationEmail } from '@core/models/INotificationEmail';

export const getNotificationTemplate = (type: TemplateType): INotificationEmail | null => {
    switch (type) {
        case TemplateType.Confirmation:
            return {
                label: 'Confirmation Email',
                body: `Hi {Invitee Full Name} \r\nYour {Event Name} with {My Name}
                at {Event Time} on {Event Date} is scheduled\r\n{Event Description}\r\n{Location}\r\n{Questions and Answers}`,
            };
        case TemplateType.Cancellation:
            return {
                label: 'Cancellation Email',
                body: `Hi {Invitee Full Name} \r\nYour {Event Name} with {My Name}
                at {Event Time} on {Event Date} is unfortunately cancelled`,
            };
        case TemplateType.Reminders:
            return {
                label: 'Reminders Email',
                body: `Hi {Invitee Full Name} \r\nThis is a friendly reminder that your {Event Name} with {My Name} is
                at {Event Time} on {Event Date}\r\n{Event Description}\r\n{Location}\r\n{Questions and Answers}`,
            };
        case TemplateType.FollowUp:
            return {
                label: 'Follow-Up Email',
                body: `Hi {Invitee Full Name} \r\nThank you for attending {Event Name} on {Event Date}
                \r\nPlease respond to this email with any feedback or additional requests.`,
            };
        default:
            return null;
    }
};
