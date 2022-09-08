import { ITeamMember } from '@core/models/ITeamMember';

import { IConfirmButtonOptions } from './confirmWindow/IConfirmButtonOptions';

export interface ITeamMembersDialogData {
    title: string;
    message?: string;
    buttonsOptions?: IConfirmButtonOptions[];
    teamMembers?: ITeamMember[];
    teamId?: number;
}
