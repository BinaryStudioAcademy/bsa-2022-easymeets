import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { MaterialModule } from '@shared/material/material.module';

import { AvailabilityPageComponent } from './availability-page/availability-page.component';
import { GeneralComponent } from './new-slot/general/general.component';
import { SlotComponent } from './slot/slot.component';
import { TeamComponent } from './team/team.component';
import { AvailabilityRoutingModule } from './availability-routing.module';

@NgModule({
    declarations: [AvailabilityPageComponent, SlotComponent, TeamComponent, GeneralComponent],
    imports: [CommonModule, AvailabilityRoutingModule, MaterialModule],
})
export class AvailabilityModule { }
