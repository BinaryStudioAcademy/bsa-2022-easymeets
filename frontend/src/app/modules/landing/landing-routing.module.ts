import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LandingGuard } from '@core/guards/landing.guard';

import { LandingPageComponent } from './landing-page/landing-page.component';

const routes: Routes = [
    {
        path: '',
        component: LandingPageComponent,
        canActivate: [LandingGuard],
    },
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule],
})
export class LandingRoutingModule {}
