import { ITeam } from '@core/interfaces/team-interface';

export const getDefaultTeams = (): ITeam[] => [
    { id: 1, name: 'Binary Team', logoPath: '', pageLink: '', timeZone: '', description: 'Text' },
    { id: 2, name: 'Work 2', logoPath: '', pageLink: '', timeZone: '', description: 'Text' },
    { id: 3, name: 'Work Team 3', logoPath: '', pageLink: '', timeZone: '', description: 'Text' },
];
