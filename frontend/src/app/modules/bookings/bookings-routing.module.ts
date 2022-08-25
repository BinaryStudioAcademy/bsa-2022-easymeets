import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthGuard } from '@core/guards/auth.guard';
import { BookersPageComponent } from '@modules/bookings/bookers-page/bookers-page.component';

import { BookingsPageComponent } from './bookings-page/bookings-page.component';

const routes: Routes = [
    {
        path: '',
        component: BookingsPageComponent,
        canActivate: [AuthGuard],
    },
    {
        path: 'bookers/:id',
        component: BookersPageComponent,
        canActivate: [AuthGuard],
    },
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule],
})
export class BookingsRoutingModule {}
