import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { MaterialModule } from '@shared/material/material.module';

import { AvailabilityPageComponent } from './availability-page/availability-page.component';
import { SlotComponent } from './slot/slot.component';
import { AvailabilityRoutingModule } from './availability-routing.module';
import { TeamComponent } from './team/team.component';

@NgModule({
    declarations: [AvailabilityPageComponent, SlotComponent, TeamComponent],
    imports: [CommonModule, AvailabilityRoutingModule, MaterialModule],
})
export class AvailabilityModule {}
