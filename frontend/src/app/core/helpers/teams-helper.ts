import { ITeam } from '@core/interfaces/team-interface';

export const getDefaultTeams = (): ITeam[] => [
    { id: 1, name: 'Binary Team' },
    { id: 2, name: 'Work 2' },
    { id: 3, name: 'Work Team 3' },
];
