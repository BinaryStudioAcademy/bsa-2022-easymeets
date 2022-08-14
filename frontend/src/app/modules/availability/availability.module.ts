import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { EditAvailabilityPageComponent } from '@modules/availability/edit-slot/edit-availability/edit-availability-page.component';
import { SideMenuModule } from '@modules/side-menu/side-menu.module';
import { MaterialModule } from '@shared/material/material.module';
import { SharedModule } from '@shared/shared.module';

import { AvailabilityPageComponent } from './availability-page/availability-page.component';
import { EventDetailComponent } from './new-slot/event-detail/event-detail.component';
import { GeneralComponent } from './new-slot/general/general.component';
import { NewAvailabilityComponent } from './new-slot/new-availability/new-availability.component';
import { SlotComponent } from './slot/slot.component';
import { SlotsBlockComponent } from './slots-block/slots-block.component';
import { AvailabilityRoutingModule } from './availability-routing.module';

@NgModule({
    declarations: [
        AvailabilityPageComponent,
        SlotComponent,
        SlotsBlockComponent,
        GeneralComponent,
        EventDetailComponent,
        NewAvailabilityComponent,
        EditAvailabilityPageComponent,
    ],
    imports: [CommonModule, AvailabilityRoutingModule, MaterialModule, SideMenuModule, SharedModule],
})
export class AvailabilityModule {}
