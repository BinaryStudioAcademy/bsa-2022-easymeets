import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EventDetailComponent } from '@modules/availability/new-slot/event-detail/event-detail.component';
import { GeneralComponent } from '@modules/availability/new-slot/general/general.component';
import { NewAvailabilityComponent } from '@modules/availability/new-slot/new-availability/new-availability.component';

import { AvailabilityPageComponent } from './availability-page/availability-page.component';
import {
    EditAvailabilityPageComponent,
} from '@modules/availability/edit-slot/edit-availability/edit-availability-page.component';

const routes: Routes = [
    {
        path: '',
        component: AvailabilityPageComponent,
    },
    {
        path: 'new',
        component: NewAvailabilityComponent,
        children: [
            {
                path: 'general',
                component: GeneralComponent,
            },
            {
                path: 'event-details',
                component: EventDetailComponent,
            },
            {
                path: '**',
                redirectTo: 'general',
            },
        ],
    },
    {
        path: 'edit/:id',
        component: EditAvailabilityPageComponent,
        children: [
            {
                path: 'general',
                component: GeneralComponent,
            },
            {
                path: 'event-details',
                component: EventDetailComponent,
            },
            {
                path: '**',
                redirectTo: 'general',
            },
        ],
    },
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule],
})
export class AvailabilityRoutingModule {}
