import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { MaterialModule } from '@shared/material/material.module';

import { GeneralComponent } from './new-slot/general/general.component';

@NgModule({
    declarations: [
        GeneralComponent,
    ],
    imports: [
        CommonModule,
        MaterialModule,
    ],
})
export class AvailabilityModule { }
