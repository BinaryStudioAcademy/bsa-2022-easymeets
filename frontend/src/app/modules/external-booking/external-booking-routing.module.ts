import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

// eslint-disable-next-line max-len
import { ExternalBookingChooseMeetingComponent } from './external-booking-choose-meeting-page/external-booking-choose-meeting-page.component';
import { ExternalBookingChooseTimeComponent } from './external-booking-choose-time-page/external-booking-choose-time-page.component';
import { ExternalBookingPageComponent } from './external-booking-page/external-booking-page.component';

const routes: Routes = [
    {
        path: '',
        component: ExternalBookingPageComponent,
        children: [
            {
                path: 'choose-meeting',
                component: ExternalBookingChooseMeetingComponent,
            },
            {
                path: 'choose-time',
                component: ExternalBookingChooseTimeComponent,
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
