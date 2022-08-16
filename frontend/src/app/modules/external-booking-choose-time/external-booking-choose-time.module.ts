import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { MaterialModule } from '@shared/material/material.module';
import { SharedModule } from '@shared/shared.module';

import { ExternalBookingChooseTimeComponent } from './external-booking-choose-time-page/external-booking-choose-time-page.component';
import { ExternalBookingChooseTimeRoutingModule } from './external-booking-choose-time-routing.module';

@NgModule({
    declarations: [ExternalBookingChooseTimeComponent],
    imports: [SharedModule, ExternalBookingChooseTimeRoutingModule, CommonModule, MaterialModule],
})
export class ExternalBookingChooseTimeModule {}
