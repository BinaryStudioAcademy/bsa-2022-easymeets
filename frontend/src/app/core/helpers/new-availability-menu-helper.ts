import { SideMenuGroupTabs } from '@core/interfaces/sideMenu/tabs/sideMenuGroupTabs';

export const getNewAvailabilityMenu = (): SideMenuGroupTabs[] => [
    {
        items: [
            { text: 'General' },
            { text: 'Schedule' },
            { text: 'Booking page' },
            { text: 'Questions' },
            { text: 'Notification Emails' },
        ],
    },
];
