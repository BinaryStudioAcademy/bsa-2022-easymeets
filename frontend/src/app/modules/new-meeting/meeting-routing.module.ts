import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthGuard } from '@core/guards/auth.guard';

import { EditMeetingComponent } from './edit-meeting/edit-meeting.component';
import { NewMeetingComponent } from './new-meeting/new-meeting.component';

const routes: Routes = [
    {
        path: 'new',
        component: NewMeetingComponent,
        canActivate: [AuthGuard],
    },
    {
        path: 'edit/:id',
        component: EditMeetingComponent,
        canActivate: [AuthGuard],
    },
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule],
})
export class MeetingRoutingModule {}
