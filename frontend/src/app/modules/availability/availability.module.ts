import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { SideMenuModule } from '@modules/side-menu/side-menu.module';
import { MaterialModule } from '@shared/material/material.module';

import { AvailabilityPageComponent } from './availability-page/availability-page.component';
import { EventDetailComponent } from './new-slot/event-detail/event-detail.component';
import { GeneralComponent } from './new-slot/general/general.component';
import { NewAvailabilityComponent } from './new-slot/new-availability/new-availability.component';
import { ScheduleComponent } from './new-slot/schedule/schedule.component';
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
        ScheduleComponent,
    ],
    imports: [CommonModule, AvailabilityRoutingModule, MaterialModule, SideMenuModule],
})
export class AvailabilityModule {}
