import { SideMenuGroup } from '@core/interfaces/sideMenu/sideMenuGroup';

export const getUserSettingsMenuItems = (): SideMenuGroup[] => [
    {
        header: 'Account',
        items: [
            { text: 'Personal', routerLink: 'account/personal' },
        ],
    },
    {
        header: 'Integrations',
        items: [
            { text: 'Calendars', routerLink: 'integrations/calendars' },
            { text: 'Video Conferencing', routerLink: 'integrations/video-conferencing' },
        ],
    },
];
