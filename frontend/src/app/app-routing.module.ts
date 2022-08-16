import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
    {
        path: '',
        loadChildren: () => import('./modules/landing/landing.module').then((m) => m.LandingModule),
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
    {
        path: 'auth',
        loadChildren: () => import('./modules/auth/auth.module').then((m) => m.AuthModule),
    },
    { path: '**', redirectTo: '', pathMatch: 'full' },
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule],
})
export class AppRoutingModule {}
