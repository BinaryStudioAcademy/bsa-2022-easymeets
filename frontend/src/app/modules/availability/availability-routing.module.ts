import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { AvailabilityPageComponent } from './availability-page/availability-page.component';

const routes: Routes = [
    {
        path: '',
        component: AvailabilityPageComponent,
    },
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule],
})
export class AvailabilityRoutingModule {}
