import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthGuard } from '@core/guards/auth.guard';

import { EditMeetingComponent } from './edit-meeting/edit-meeting.component';

const routes: Routes = [
    {
        path: ':id',
        component: EditMeetingComponent,
        canActivate: [AuthGuard],
    },
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule],
})
export class EditMeetingRoutingModule {}
