import { INewMeetingMember } from '@core/models/INewMeetingTeamMember';
import { IConfirmButtonOptions } from '@shared/models/confirmWindow/IConfirmButtonOptions';

export interface IConfirmDialogData {
    title: string;
    message?: string;
    buttonsOptions: IConfirmButtonOptions[];
    titleImagePath?: string;
    date?: string;
    time?: Date;
    duration?: number;
    meetingName?: string;
    participants?: INewMeetingMember[];
    location?: string;
    link?: string;
}
