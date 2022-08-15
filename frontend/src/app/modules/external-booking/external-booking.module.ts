import { NgModule } from '@angular/core';
import { SharedModule } from '@shared/shared.module';

import { ExternalBookingPageComponent } from './external-booking-page/external-booking-page.component';
import { ExternalBookingRoutingModule } from './external-booking-routing.module';

@NgModule({
    declarations: [ExternalBookingPageComponent],
    imports: [SharedModule, ExternalBookingRoutingModule],
})
export class ExternalBookingModule {}
