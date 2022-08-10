import { ITeam } from './team-interface';

export interface IUserCalendar {
    id: number;
    email: string;
    teamsFor: ITeam[] | null;
    teamFrom: ITeam | null;
    checkForConflicts: boolean;
}
