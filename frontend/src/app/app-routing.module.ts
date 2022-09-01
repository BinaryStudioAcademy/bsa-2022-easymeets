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
        path: 'bookings',
        loadChildren: () => import('./modules/bookings/bookings.module').then((m) => m.BookingsModule),
    },
    {
        path: 'settings',
        loadChildren: () => import('./modules/settings/settings.module').then((m) => m.SettingsModule),
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
    {
        path: 'new-meeting',
        loadChildren: () => import('./modules/new-meeting/new-meeting.module').then((m) => m.NewMeetingModule),
    },
    { path: '**', redirectTo: '', pathMatch: 'full' },
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule],
})
export class AppRoutingModule {}
