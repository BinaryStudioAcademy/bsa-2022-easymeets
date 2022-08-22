import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { UserProfilePageComponent } from '@modules/settings/user/user-profile-page/user-profile-page.component';

const routes: Routes = [
    {
        path: '',
        component: UserProfilePageComponent,
        children: [
            {
                path: 'personal',
                component: UserProfilePageComponent,
            },
            {
                path: '**',
                redirectTo: 'personal',
            },
        ],
    },
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule],
})
export class UserRoutingModule {}
