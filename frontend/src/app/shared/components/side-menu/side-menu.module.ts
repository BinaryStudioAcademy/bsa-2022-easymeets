import { NgModule } from '@angular/core';
import { MaterialModule } from '@shared/material/material.module';

import { SideMenuHeaderComponent } from './side-menu-header/side-menu-header.component';
import { SideMenuItemComponent } from './side-menu-item/side-menu-item.component';
import { SideMenuComponent } from './side-menu.component';

@NgModule({
    imports: [MaterialModule],
    declarations: [SideMenuComponent, SideMenuItemComponent, SideMenuHeaderComponent],
    exports: [SideMenuComponent, SideMenuItemComponent, SideMenuHeaderComponent],
})
export class SideMenuModule {}
