import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { HeaderModule } from '@modules/header/header.module';
import { SideMenuModule } from '@modules/side-menu/side-menu.module';
import { MaterialModule } from '@shared/material/material.module';

import { AvailabilityPageComponent } from './availability-page/availability-page.component';
import { EditAvailabilityPageComponent } from './edit-slot/edit-availability-page/edit-availability-page.component';
import { EventDetailComponent } from './new-slot/event-detail/event-detail.component';
import { GeneralComponent } from './new-slot/general/general.component';
import { NewAvailabilityComponent } from './new-slot/new-availability/new-availability.component';
import { NewAvailabilityPageComponent } from './new-slot/new-availability-page/new-availability-page.component';
import { SlotComponent } from './slot/slot.component';
import { TeamComponent } from './team/team.component';
import { UserSlotComponent } from './user-slot/user-slot.component';
import { AvailabilityRoutingModule } from './availability-routing.module';

@NgModule({
    declarations: [
        AvailabilityPageComponent,
        SlotComponent,
        TeamComponent,
        UserSlotComponent,
        GeneralComponent,
        EventDetailComponent,
        NewAvailabilityComponent,
        EditAvailabilityPageComponent,
        NewAvailabilityPageComponent,
    ],
    imports: [CommonModule, AvailabilityRoutingModule, MaterialModule, SideMenuModule, HeaderModule],
})
export class AvailabilityModule {}
