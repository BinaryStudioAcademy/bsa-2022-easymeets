import { NgModule } from '@angular/core';
import { HeaderModule } from '@modules/header/header.module';
import { SharedModule } from '@shared/shared.module';

import { MainComponent } from './main-page/main-page.component';
import { MainRoutingModule } from './main-routing.module';

@NgModule({
    declarations: [MainComponent],
    imports: [SharedModule, MainRoutingModule, HeaderModule],
})
export class MainModule {}
