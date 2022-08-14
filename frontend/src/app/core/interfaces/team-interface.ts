import { IUser } from "@core/interfaces/user/user-interface";
import { TimeZone } from "@core/enums/time-zone.enum";

export interface ITeam {
    id: number;
    logoPath: string;
    name: string;
    pageLink: string;
    timeZone: string;
    description: string;
    members?: IUser[];
}
