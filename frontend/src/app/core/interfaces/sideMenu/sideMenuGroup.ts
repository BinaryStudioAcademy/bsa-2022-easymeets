import { SideMenuItem } from './sideMenuItem';

export interface SideMenuGroup {
    header?: string;
    items: SideMenuItem[];
    showButton?: boolean;
    buttonText?: string;
    buttonRouterLink?: string;
}
