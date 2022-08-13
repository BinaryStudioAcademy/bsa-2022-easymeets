import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { UserProfilePageComponent } from '@modules/user/user-profile-page/user-profile-page.component';

import { UserSettingsPageComponent } from './user-settings-page/user-settings-page.component';

const routes: Routes = [
    // {
    //     path: '',
    //     component: UserProfilePageComponent,
    // },
    {
        path: 'account',
        component: UserSettingsPageComponent,
        children: [
            {
                path: 'personal',
                component: UserProfilePageComponent,
            },
        ],
    },
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule],
})
export class UserRoutingModule {}
