import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { MaterialModule } from '@shared/material/material.module';
import { SharedModule } from '@shared/shared.module';
import { MomentTimezonePickerModule } from 'moment-timezone-picker';

import { ExternalBookingMeetingComponent } from './external-booking-choose-meeting-page/external-booking-choose-meeting-page.component';
import { ExternalBookingMembersComponent } from './external-booking-choose-members-page/external-booking-choose-members-page.component';
import { ExternalBookingTimeComponent } from './external-booking-choose-time-page/external-booking-choose-time-page.component';
import { ExternalBookingConfirmPageComponent } from './external-booking-confirm-page/external-booking-confirm-page.component';
import { ExternalBookingConfirmedComponent } from './external-booking-confirmed-page/external-booking-confirmed-page.component';
import { ExternalBookingPageComponent } from './external-booking-page/external-booking-page.component';
import { ExternalBookingSlotComponent } from './external-booking-slot/external-booking-slot.component';
import { ExternalBookingRoutingModule } from './external-booking-routing.module';

@NgModule({
    declarations: [
        ExternalBookingPageComponent,
        ExternalBookingMeetingComponent,
        ExternalBookingTimeComponent,
        ExternalBookingConfirmPageComponent,
        ExternalBookingMembersComponent,
        ExternalBookingConfirmedComponent,
        ExternalBookingSlotComponent,
    ],
    imports: [SharedModule, ExternalBookingRoutingModule, CommonModule, MaterialModule, MomentTimezonePickerModule],
})
export class ExternalBookingModule {}
