import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';

import { AvailabilityPageComponent } from './availability-page/availability-page.component';
import { AvailabilityRoutingModule } from './availability-routing.module';

@NgModule({
    declarations: [AvailabilityPageComponent],
    imports: [CommonModule, AvailabilityRoutingModule],
})
export class AvailabilityModule {}
