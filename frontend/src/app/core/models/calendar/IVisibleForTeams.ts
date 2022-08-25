import { ITeam } from '../ITeam';

export interface IVisibleForTeams {
    calendarId: bigint;
    teamId: bigint;
    team?: ITeam;
}
