import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
    {
        path: '',
        loadChildren: () => import('./modules/landing/landing.module').then((m) => m.LandingModule),
    },
    {
        path: 'main',
        loadChildren: () => import('./modules/main/main.module').then((m) => m.MainModule),
    },
    {
        path: 'availability',
        loadChildren: () => import('./modules/availability/availability.module').then((m) => m.AvailabilityModule),
    },
    {
        path: 'user',
        loadChildren: () => import('./modules/user/user.module').then((m) => m.UserModule),
    },
    {
        path: 'external-booking',
        loadChildren: () =>
            import('./modules/external-booking/external-booking.module').then((m) => m.ExternalBookingModule),
    },
    { path: '**', redirectTo: '', pathMatch: 'full' },
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule],
})
export class AppRoutingModule {}
