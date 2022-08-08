import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { MaterialModule } from '@shared/material/material.module';

import { AvailabilityPageComponent } from './availability-page/availability-page.component';
import { SlotComponent } from './slot/slot.component';
import { AvailabilityRoutingModule } from './availability-routing.module';

@NgModule({
    declarations: [AvailabilityPageComponent, SlotComponent],
    imports: [CommonModule, AvailabilityRoutingModule, MaterialModule],
})
export class AvailabilityModule {}
