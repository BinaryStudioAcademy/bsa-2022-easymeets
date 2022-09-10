import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { TeamComponent } from '@modules/availability/team/team.component';
import { EditTeamComponent } from '@modules/settings/team/edit-team/edit-team.component';
import { NewTeamComponent } from '@modules/settings/team/new-team/new-team.component';

import { TeamMembersComponent } from './team-members/team-members.component';

const routes: Routes = [
    {
        path: '',
        component: TeamComponent,
    },
    {
        path: 'edit/:id',
        component: EditTeamComponent,
    },
    {
        path: 'new',
        component: NewTeamComponent,
    },
    {
        path: 'members/:id',
        component: TeamMembersComponent,
    },
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule],
})
export class TeamRoutingModule {}
