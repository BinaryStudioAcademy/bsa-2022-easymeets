import { ITeam } from '../ITeam';

export interface IUserCalendar {
    id: bigint;
    connectedCalendar: string;
    importEventsFromTeam?: ITeam;
    visibleForTeams?: ITeam[];
    checkForConflicts: boolean;
}
