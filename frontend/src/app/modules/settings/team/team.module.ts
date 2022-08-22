import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { TeamRoutingModule } from '@modules/settings/team/team-routing.module';
import { MaterialModule } from '@shared/material/material.module';
import { SharedModule } from '@shared/shared.module';

import { TeamPreferencesComponent } from './team-preferences/team-preferences.component';

@NgModule({
    declarations: [
        TeamPreferencesComponent,
    ],
    imports: [
        CommonModule,
        SharedModule,
        MaterialModule,
        TeamRoutingModule,
    ],
})
export class TeamModule { }
