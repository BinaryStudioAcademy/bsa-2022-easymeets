import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { HeaderModule } from '@modules/header/header.module';
import { NewMeetingCalendarHeaderComponent } from '@modules/new-meeting/new-meeting-calendar-header/new-meeting-calendar-header.component';
import { SideMenuModule } from '@modules/side-menu/side-menu.module';
import { MaterialModule } from '@shared/material/material.module';
import { SharedModule } from '@shared/shared.module';
import { CalendarModule, DateAdapter } from 'angular-calendar';
import { adapterFactory } from 'angular-calendar/date-adapters/date-fns';
import { MomentTimezonePickerModule } from 'moment-timezone-picker';

import { EditMeetingComponent } from './edit-meeting/edit-meeting.component';
import { NewMeetingComponent } from './new-meeting/new-meeting.component';
import { NewMeetingCalendarComponent } from './new-meeting-calendar/new-meeting-calendar.component';
import { MeetingRoutingModule } from './meeting-routing.module';

@NgModule({
    declarations: [
        NewMeetingComponent,
        NewMeetingCalendarComponent,
        NewMeetingCalendarHeaderComponent,
        EditMeetingComponent,
    ],
    imports: [
        CommonModule,
        MeetingRoutingModule,
        MaterialModule,
        HeaderModule,
        SideMenuModule,
        SharedModule,
        MomentTimezonePickerModule,
        CalendarModule.forRoot({
            provide: DateAdapter,
            useFactory: adapterFactory,
        }),
    ],
})
export class MeetingModule {}
