import { Component, EventEmitter, Input, Output } from '@angular/core';
import { SideMenuGroup } from '@core/interfaces/sideMenu/sideMenuGroup';

@Component({
    selector: 'app-side-menu',
    templateUrl: './side-menu.component.html',
    styleUrls: ['./side-menu.component.sass'],
})
export class SideMenuComponent {
    @Input() groups: SideMenuGroup[];

    @Input() currentIndex: number = 0;

    @Output() currentIndexChange: EventEmitter<number> = new EventEmitter<number>();
}
