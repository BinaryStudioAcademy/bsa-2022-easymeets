import { AfterContentInit, Component, ContentChildren, QueryList } from '@angular/core';

import { SideMenuItemComponent } from './side-menu-item/side-menu-item.component';

@Component({
    selector: 'app-side-menu',
    templateUrl: './side-menu.component.html',
    styleUrls: ['./side-menu.component.sass'],
})
export class SideMenuComponent implements AfterContentInit {
    public static SelectedMenuItem: SideMenuItemComponent | undefined;

    @ContentChildren(SideMenuItemComponent) items: QueryList<SideMenuItemComponent>;

    ngAfterContentInit(): void {
        this.items.forEach((item) => {
            item.toggleHandler?.subscribe({ next: this.select });
        });

        SideMenuComponent.SelectedMenuItem = this.items.find((item) => item instanceof SideMenuItemComponent);

        SideMenuComponent.SelectedMenuItem?.toggleSelection();
    }

    public select(component: SideMenuItemComponent) {
        component.toggleSelection();
        SideMenuComponent.SelectedMenuItem?.toggleSelection();

        SideMenuComponent.SelectedMenuItem = component;
    }
}
