import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { NewMeetingModule } from '@modules/new-meeting/new-meeting.module';

import { EditMeetingComponent } from './edit-meeting/edit-meeting.component';
import { EditMeetingRoutingModule } from './edit-meeting-routing.module';

@NgModule({
    declarations: [EditMeetingComponent],
    imports: [CommonModule, EditMeetingRoutingModule, NewMeetingModule],
})
export class EditMeetingModule {}
