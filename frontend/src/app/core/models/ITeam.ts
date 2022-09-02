import { ITimeZone } from './ITimeZone';

export interface ITeam {
    id: number;
    image?: string;
    name: string;
    pageLink: string;
    timeZone: ITimeZone;
    description: string;
}
