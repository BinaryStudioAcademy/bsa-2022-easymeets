import { SideMenuGroup } from '@core/interfaces/sideMenu/sideMenuGroup';

export const getNewAvailabilityMenu = (): SideMenuGroup[] => [{
    items: [
        { text: 'General', routerLink: 'general' },
        { text: 'Booking page', routerLink: 'event-details' },
    ],
}];
