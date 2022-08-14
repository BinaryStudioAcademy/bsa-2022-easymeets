import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { GeneralComponent } from '@modules/availability/new-slot/general/general.component';

import { AvailabilityPageComponent } from './availability-page/availability-page.component';
import { EventDetailComponent } from './new-slot/event-detail/event-detail.component';
import { NewAvailabilityComponent } from './new-slot/new-availability/new-availability.component';

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
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule],
})
export class AvailabilityRoutingModule {}
