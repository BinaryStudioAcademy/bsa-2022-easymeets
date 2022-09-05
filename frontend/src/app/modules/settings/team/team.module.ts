import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { TeamRoutingModule } from '@modules/settings/team/team-routing.module';
import { MaterialModule } from '@shared/material/material.module';
import { SharedModule } from '@shared/shared.module';
import { MomentTimezonePickerModule } from 'moment-timezone-picker';

import { EditTeamComponent } from './edit-team/edit-team.component';
import { NewTeamComponent } from './new-team/new-team.component';
import { TeamPreferencesComponent } from './team-preferences/team-preferences.component';

@NgModule({
    declarations: [TeamPreferencesComponent, NewTeamComponent, EditTeamComponent],
    imports: [CommonModule, SharedModule, MaterialModule, TeamRoutingModule, MomentTimezonePickerModule],
})
export class TeamModule {}
