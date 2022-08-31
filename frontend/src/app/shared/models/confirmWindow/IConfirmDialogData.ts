import { INewMeetingMember } from '@core/models/INewMeetingTeamMember';
import { LocationType } from '@shared/enums/locationType';
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
    location?: LocationType;
    link?: string;
}
