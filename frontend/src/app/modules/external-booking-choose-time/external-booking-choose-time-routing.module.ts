import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { ExternalBookingChooseTimeComponent } from './external-booking-choose-time-page/external-booking-choose-time-page.component';

const routes: Routes = [
    {
        path: '',
        component: ExternalBookingChooseTimeComponent,
    },
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule],
})
export class ExternalBookingChooseTimeRoutingModule {}
