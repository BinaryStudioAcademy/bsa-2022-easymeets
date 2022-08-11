import { ITeam } from './team-interface';

export interface IUserCalendar {
    id: number;
    email: string;
    teamsFor?: ITeam[];
    teamFrom?: ITeam;
    checkForConflicts: boolean;
}
