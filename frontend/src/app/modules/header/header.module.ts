import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { MatSelectModule } from '@shared/material/material.module';

import { HeaderItemComponent } from './header-item/header-item.component';

@NgModule({
    declarations: [HeaderItemComponent],
    imports: [CommonModule, MatSelectModule],
    exports: [HeaderItemComponent],
})
export class HeaderModule {}
