import { IUser } from '@core/interfaces/user/user-interface';

export interface ITeam {
    id: number;
    logoPath: string;
    name: string;
    pageLink: string;
    timeZone: string;
    description: string;
    members?: IUser[];
}
