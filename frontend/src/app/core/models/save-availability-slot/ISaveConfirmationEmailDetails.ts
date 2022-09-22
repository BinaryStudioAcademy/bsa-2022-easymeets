import { TemplateType } from '@core/enums/template-type.enum';

export interface ISaveConfirmationEmailDetails {
    allowToSend: boolean;
    emailSubject?: string;
    emailBody?: string;
    type: TemplateType;
    timeValue?: string;
}
