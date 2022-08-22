import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
    {
        path: 'availability',
        loadChildren: () => import('@modules/availability/availability.module').then((m) => m.AvailabilityModule),
    },
    {
        path: 'bookings',
        loadChildren: () => import('@modules/bookings/bookings.module').then((m) => m.BookingsModule),
    },
    { path: '**', redirectTo: '', pathMatch: 'full' },
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule],
})
export class HeaderRoutingModule {}
