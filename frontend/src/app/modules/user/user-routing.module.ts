import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CalendarsPageComponent } from '@modules/calendars/calendars-page/calendars-page.component';
import { TeamPreferencesComponent } from '@modules/team/team-preferences/team-preferences.component';
import { UserProfilePageComponent } from '@modules/user/user-profile-page/user-profile-page.component';

import { UserSettingsPageComponent } from './user-settings-page/user-settings-page.component';

const routes: Routes = [
    {
        path: '',
        component: UserSettingsPageComponent,
        children: [
            {
                path: 'account/personal',
                component: UserProfilePageComponent,
            },
            {
                path: 'account/team',
                component: TeamPreferencesComponent,
            },
            {
                path: 'integrations/calendars',
                component: CalendarsPageComponent,
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
export class UserRoutingModule {}
