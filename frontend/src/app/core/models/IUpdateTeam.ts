import { ITimeZone } from './ITimeZone';

export interface IUpdateTeam {
    id: number;
    name: string;
    image?: string;
    pageLink: string;
    timeZone: ITimeZone;
    description: string;
}
