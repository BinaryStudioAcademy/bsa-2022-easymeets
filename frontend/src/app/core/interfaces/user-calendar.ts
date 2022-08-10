import { Team } from './team-interface';

export interface UserCalendar {
    id: number;
    email: string;
    teamsFor: Team[] | null;
    teamFrom: Team | null;
    checkForConflicts: boolean;
}
