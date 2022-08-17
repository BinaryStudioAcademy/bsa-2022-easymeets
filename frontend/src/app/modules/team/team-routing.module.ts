import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { TeamPreferencesComponent } from '@modules/team/team-preferences/team-preferences.component';

const routes: Routes = [
    {
        path: '',
        component: TeamPreferencesComponent,
    },
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule],
})
export class TeamRoutingModule {}
