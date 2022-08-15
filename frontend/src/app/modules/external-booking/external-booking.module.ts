import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { MaterialModule } from '@shared/material/material.module';
import { SharedModule } from '@shared/shared.module';

import { ExternalBookingPageComponent } from './external-booking-page/external-booking-page.component';
import { ExternalBookingRoutingModule } from './external-booking-routing.module';

@NgModule({
    declarations: [ExternalBookingPageComponent],
    imports: [SharedModule, ExternalBookingRoutingModule, CommonModule, MaterialModule],
})
export class ExternalBookingModule {}
