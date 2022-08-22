import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { BookingsPageComponent } from './bookings-page/bookings-page.component';

const routes: Routes = [
    {
        path: '',
        component: BookingsPageComponent,
    },
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule],
})
export class BookingsRoutingModule {}
