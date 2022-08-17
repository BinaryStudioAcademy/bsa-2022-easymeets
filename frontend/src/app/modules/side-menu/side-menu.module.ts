import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { SideMenuComponent } from '@modules/side-menu/menu/side-menu.component';
import { MaterialModule } from '@shared/material/material.module';
import { SideMenuTabsComponent } from './tabs-menu/side-menu-tabs.component';

@NgModule({
    declarations: [SideMenuTabsComponent, SideMenuComponent],
    imports: [RouterModule, MaterialModule],
    exports: [SideMenuTabsComponent, SideMenuComponent],
})
export class SideMenuModule {}
