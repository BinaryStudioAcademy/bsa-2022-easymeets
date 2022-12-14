import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthGuard } from '@core/guards/auth.guard';
import { CalendarsPageComponent } from '@modules/calendars/calendars-page/calendars-page.component';
import { SettingsPageComponent } from '@modules/settings/settings-page/settings-page.component';
import { VideoConferencingComponent } from '@modules/settings/video-conferencing/video-conferencing.component';

const routes: Routes = [
    {
        path: '',
        component: SettingsPageComponent,
        canActivate: [AuthGuard],
        children: [
            {
                path: 'account',
                loadChildren: () => import('./user/user.module').then((m) => m.UserModule),
            },
            {
                path: 'teams',
                loadChildren: () => import('./team/team.module').then((m) => m.TeamModule),
            },
            {
                path: 'integrations/calendars',
                component: CalendarsPageComponent,
            },
            {
                path: 'integrations/video-conferencing',
                component: VideoConferencingComponent,
            },
            {
                path: '**',
                redirectTo: 'account/personal',
            },
        ],
    },
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule],
})
export class SettingsRoutingModule {}
