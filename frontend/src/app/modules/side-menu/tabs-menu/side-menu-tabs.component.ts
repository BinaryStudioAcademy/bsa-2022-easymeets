import { Component, EventEmitter, Input, Output } from '@angular/core';
import { SideMenuGroupTabs } from "@core/interfaces/sideMenu/tabs/sideMenuGroupTabs";

@Component({
    selector: 'app-side-menu-tabs',
    templateUrl: './side-menu-tabs.component.html',
    styleUrls: ['./side-menu-tabs.component.sass'],
})
export class SideMenuTabsComponent {
    @Input() groups: SideMenuGroupTabs[];

    @Input() currentIndex: number = 0;

    @Output() currentIndexChange: EventEmitter<number> = new EventEmitter<number>();
}
