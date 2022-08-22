import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { MaterialModule } from '@shared/material/material.module';
import { SharedModule } from '@shared/shared.module';

import { HeaderItemComponent } from './header-item/header-item.component';
import { HeaderRoutingModule } from './header-routing.module';

@NgModule({
    declarations: [HeaderItemComponent],
    imports: [CommonModule, SharedModule, MaterialModule, HeaderRoutingModule],
    exports: [HeaderItemComponent],
})
export class HeaderModule {}
