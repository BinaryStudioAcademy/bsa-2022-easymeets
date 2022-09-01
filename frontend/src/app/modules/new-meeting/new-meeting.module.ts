import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { HeaderModule } from '@modules/header/header.module';
import { SideMenuModule } from '@modules/side-menu/side-menu.module';
import { MaterialModule } from '@shared/material/material.module';
import { SharedModule } from '@shared/shared.module';

import { NewMeetingComponent } from './new-meeting/new-meeting.component';
import { NewMeetingRoutingModule } from './new-meeting-routing.module';

@NgModule({
    declarations: [NewMeetingComponent],
    imports: [CommonModule, NewMeetingRoutingModule, MaterialModule, HeaderModule, SideMenuModule, SharedModule],
})
export class NewMeetingModule {}
