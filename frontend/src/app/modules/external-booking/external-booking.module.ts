import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { MaterialModule } from '@shared/material/material.module';
import { SharedModule } from '@shared/shared.module';

import { ExternalBookingMeetingComponent } from './external-booking-choose-meeting-page/external-booking-choose-meeting-page.component';
import { ExternalBookingTimeComponent } from './external-booking-choose-time-page/external-booking-choose-time-page.component';
import { ExternalBookingConfirmPageComponent } from './external-booking-confirm-page/external-booking-confirm-page.component';
import { ExternalBookingPageComponent } from './external-booking-page/external-booking-page.component';
import { ExternalBookingRoutingModule } from './external-booking-routing.module';

@NgModule({
    declarations: [
        ExternalBookingPageComponent,
        ExternalBookingMeetingComponent,
        ExternalBookingTimeComponent,
        ExternalBookingConfirmPageComponent,
    ],
    imports: [SharedModule, ExternalBookingRoutingModule, CommonModule, MaterialModule],
})
export class ExternalBookingModule {}
