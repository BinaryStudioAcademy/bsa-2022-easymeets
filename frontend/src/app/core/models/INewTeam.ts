import { ITimeZone } from './ITimeZone';

export interface INewTeam {
    image?: string;
    name: string;
    pageLink: string;
    timeZone: ITimeZone;
    description: string;
}
