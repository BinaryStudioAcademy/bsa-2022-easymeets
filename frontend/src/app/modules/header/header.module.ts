import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { MaterialModule } from '@shared/material/material.module';

import { HeaderItemComponent } from './header-item/header-item.component';

@NgModule({
    declarations: [HeaderItemComponent],
    imports: [CommonModule, MaterialModule],
    exports: [HeaderItemComponent],
})
export class HeaderModule {}
