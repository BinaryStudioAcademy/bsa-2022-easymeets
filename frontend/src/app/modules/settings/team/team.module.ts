import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { TeamRoutingModule } from '@modules/settings/team/team-routing.module';
import { MaterialModule } from '@shared/material/material.module';
import { SharedModule } from '@shared/shared.module';

import { EditTeamComponent } from './edit-team/edit-team.component';
import { NewTeamComponent } from './new-team/new-team.component';
import { TeamMembersComponent } from './team-members/team-members.component';
import { TeamPreferencesComponent } from './team-preferences/team-preferences.component';
import { TeamTabsMenuComponent } from './team-tabs-menu/team-tabs-menu.component';

@NgModule({
    declarations: [
        TeamPreferencesComponent,
        NewTeamComponent,
        EditTeamComponent,
        TeamMembersComponent,
        TeamTabsMenuComponent,
    ],
    imports: [CommonModule, SharedModule, MaterialModule, TeamRoutingModule],
})
export class TeamModule {}
