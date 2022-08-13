import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CalendarsPageComponent } from '@modules/calendars/calendars-page/calendars-page.component';
import { UserProfilePageComponent } from '@modules/user/user-profile-page/user-profile-page.component';

import { UserSettingsPageComponent } from './user-settings-page/user-settings-page.component';

const routes: Routes = [
    // {
    //     path: '',
    //     component: UserProfilePageComponent,
    // },
    {
        path: '',
        component: UserSettingsPageComponent,
        children: [
            {
                path: 'account/personal',
                component: UserProfilePageComponent,
            },
            {
                path: 'integrations/calendar',
                component: CalendarsPageComponent,
            },
        ],
    },
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule],
})
export class UserRoutingModule {}
