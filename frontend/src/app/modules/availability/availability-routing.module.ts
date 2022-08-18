import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthGuard } from '@core/guards/auth.guard';
import { EditAvailabilityPageComponent } from '@modules/availability/edit-slot/edit-availability-page/edit-availability-page.component';
import { NewAvailabilityPageComponent } from '@modules/availability/new-slot/new-availability-page/new-availability-page.component';

import { AvailabilityPageComponent } from './availability-page/availability-page.component';

const routes: Routes = [
    {
        path: '',
        component: AvailabilityPageComponent,
        canActivate: [AuthGuard],
        children: [
            {
                path: 'new',
                component: NewAvailabilityPageComponent,
            },
            {
                path: 'edit/:id',
                component: EditAvailabilityPageComponent,
            },
        ],
    },
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule],
})
export class AvailabilityRoutingModule {}
