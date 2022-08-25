import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthGuard } from '@core/guards/auth.guard';

import { ExternalBookingMeetingComponent } from './external-booking-choose-meeting-page/external-booking-choose-meeting-page.component';
import { ExternalBookingTimeComponent } from './external-booking-choose-time-page/external-booking-choose-time-page.component';
import { ExternalBookingConfirmPageComponent } from './external-booking-confirm-page/external-booking-confirm-page.component';
import { ExternalBookingPageComponent } from './external-booking-page/external-booking-page.component';

const routes: Routes = [
    {
        path: '',
        component: ExternalBookingPageComponent,
        children: [
            {
                path: 'choose-meeting',
                component: ExternalBookingMeetingComponent,
            },
            {
                path: 'choose-time',
                component: ExternalBookingTimeComponent,
            },
            {
                path: 'confirm-booking',
                component: ExternalBookingConfirmPageComponent,
            },
            {
                path: '**',
                redirectTo: 'choose-meeting',
            },
        ],
        canActivate: [AuthGuard],
    },
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule],
})
export class ExternalBookingRoutingModule {}
