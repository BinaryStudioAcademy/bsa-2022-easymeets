import { Team } from './team-interface';

export interface UserCalendar {
    id: number;
    email: string;
    teamsFor: Team[];
    teamFrom: Team[];
    checkForConflicts: boolean;
}
