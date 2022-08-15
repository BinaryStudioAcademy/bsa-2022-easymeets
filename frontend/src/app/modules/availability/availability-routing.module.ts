import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { GeneralComponent } from '@modules/availability/new-slot/general/general.component';

import { AvailabilityPageComponent } from './availability-page/availability-page.component';
import { EventDetailComponent } from './new-slot/event-detail/event-detail.component';
import { NewAvailabilityComponent } from './new-slot/new-availability/new-availability.component';
import {
    EditAvailabilityPageComponent
} from "@modules/availability/edit-slot/edit-availability-page/edit-availability-page.component";

const routes: Routes = [
    {
        path: '',
        component: AvailabilityPageComponent,
    },
    {
        path: 'new',
        component: NewAvailabilityComponent,
    },
    {
        path: 'edit/:id',
        component: EditAvailabilityPageComponent
    },
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule],
})
export class AvailabilityRoutingModule {}
