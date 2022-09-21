import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { ExternalBookingMeetingComponent } from './external-booking-choose-meeting-page/external-booking-choose-meeting-page.component';
import { ExternalBookingMembersComponent } from './external-booking-choose-members-page/external-booking-choose-members-page.component';
import { ExternalBookingTimeComponent } from './external-booking-choose-time-page/external-booking-choose-time-page.component';
import { ExternalBookingConfirmPageComponent } from './external-booking-confirm-page/external-booking-confirm-page.component';
import { ExternalBookingConfirmedComponent } from './external-booking-confirmed-page/external-booking-confirmed-page.component';
import { ExternalBookingPageComponent } from './external-booking-page/external-booking-page.component';

const routes: Routes = [
    {
        path: '',
        component: ExternalBookingPageComponent,
        children: [
            {
                path: 'choose-meeting/:userLink',
                component: ExternalBookingMeetingComponent,
            },
            {
                path: 'choose-time/:slotLink',
                component: ExternalBookingTimeComponent,
            },
            {
                path: 'confirm-booking',
                component: ExternalBookingConfirmPageComponent,
            },
            {
                path: 'confirmed-booking',
                component: ExternalBookingConfirmedComponent,
            },
            {
                path: 'choose-team-members',
                component: ExternalBookingMembersComponent,
            },
            {
                path: '**',
                redirectTo: 'choose-meeting',
            },
        ],
    },
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule],
})
export class ExternalBookingRoutingModule {}
