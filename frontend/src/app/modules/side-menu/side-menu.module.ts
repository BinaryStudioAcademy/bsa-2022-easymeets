import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { MaterialModule } from '@shared/material/material.module';

import { SideMenuComponent } from './component/side-menu.component';

@NgModule({
    declarations: [SideMenuComponent],
    imports: [RouterModule, MaterialModule],
    exports: [SideMenuComponent],
})
export class SideMenuModule {}
