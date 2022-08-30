import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthGuard } from '@core/guards/auth.guard';

import { NewMeetingComponent } from './new-meeting/new-meeting.component';

const routes: Routes = [
    {
        path: '',
        component: NewMeetingComponent,
        canActivate: [AuthGuard],
    },
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule],
})
export class NewMeetingRoutingModule {}
