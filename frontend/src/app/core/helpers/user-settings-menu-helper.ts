import { SideMenuGroup } from '@core/interfaces/sideMenu/sideMenuGroup';

export const getUserSettingsMenuItems = (): SideMenuGroup[] => [
    {
        header: 'Account',
        items: [
            { text: 'Personal', routerLink: 'account/personal' },
            { text: 'Login & Password', routerLink: 'default-route' },
            { text: 'Payments', routerLink: 'default-route' },
        ],
    },
    {
        header: 'Intergations',
        items: [
            { text: 'Calendars', routerLink: 'integrations/calendars' },
            { text: 'Video Conferencing', routerLink: 'default-route' },
            { text: 'Mailing', routerLink: 'default-route' },
            { text: 'API & Tokens', routerLink: 'default-route' },
        ],
    },
    {
        header: 'Teams',
        items: [
            { text: 'Binary Team', routerLink: 'account/team' },
            { text: 'Work 2', routerLink: 'default-route' },
            { text: 'Work Team 3', routerLink: 'default-route' },
        ],
    },
];
