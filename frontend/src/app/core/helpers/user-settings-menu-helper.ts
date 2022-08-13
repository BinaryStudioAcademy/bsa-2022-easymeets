import { SideMenuGroup } from '@core/interfaces/sideMenu/sideMenuGroup';

export const getUserSettingsMenuItems = (): SideMenuGroup[] => [
    {
        header: 'Account',
        items: [
            { text: 'Personal', routerLink: 'personal' },
            { text: 'Login & Password', routerLink: 'login-password' },
            { text: 'Payments', routerLink: 'payments' },
        ],
    },
];
