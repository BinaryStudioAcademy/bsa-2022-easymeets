import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EditTeamComponent } from '@modules/settings/team/edit-team/edit-team.component';
import { NewTeamComponent } from '@modules/settings/team/new-team/new-team.component';

const routes: Routes = [
    {
        path: 'edit/:id',
        component: EditTeamComponent,
    },
    {
        path: 'new',
        component: NewTeamComponent,
    },
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule],
})
export class TeamRoutingModule {}
