import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { PendingChangesGuard } from '@core/guards/pending-changes.guard';
import { CustomTimeComponent } from '@modules/availability/new-slot/general/custom-time/custom-time.component';
import { ExclusionDatesModule } from '@modules/exclusion-dates/exclusion-dates.module';
import { HeaderModule } from '@modules/header/header.module';
import { SideMenuModule } from '@modules/side-menu/side-menu.module';
import { MaterialModule } from '@shared/material/material.module';
import { SharedModule } from '@shared/shared.module';
import { CalendarModule, DateAdapter } from 'angular-calendar';
import { adapterFactory } from 'angular-calendar/date-adapters/date-fns';
import { MomentTimezonePickerModule } from 'moment-timezone-picker';

import { AvailabilityPageComponent } from './availability-page/availability-page.component';
import { EditAvailabilityPageComponent } from './edit-slot/edit-availability-page/edit-availability-page.component';
import { EventDetailComponent } from './new-slot/event-detail/event-detail.component';
import { GeneralComponent } from './new-slot/general/general.component';
import { NewAvailabilityComponent } from './new-slot/new-availability/new-availability.component';
import { NewAvailabilityPageComponent } from './new-slot/new-availability-page/new-availability-page.component';
import { NotificationEmailsComponent } from './new-slot/notification-emails/notification-emails.component';
import { QuestionsComponent } from './new-slot/questions/questions.component';
import { ScheduleComponent } from './new-slot/schedule/schedule.component';
import { ExclusionDateComponent } from './new-slot/schedule-definition/exclusion-date/exclusion-date.component';
import { ScheduleDefinitionComponent } from './new-slot/schedule-definition/schedule-definition.component';
import { ScheduleExternalComponent } from './new-slot/schedule-external/schedule-external.component';
import { ScheduleListItemComponent } from './new-slot/schedule-list-item/schedule-list-item.component';
import { ScheduleMonthComponent } from './new-slot/schedule-month/schedule-month.component';
import { ScheduleWeekComponent } from './new-slot/schedule-week/schedule-week.component';
import { SlotComponent } from './slot/slot.component';
import { TeamComponent } from './team/team.component';
import { UserSlotComponent } from './user-slot/user-slot.component';
import { AvailabilityRoutingModule } from './availability-routing.module';

@NgModule({
    declarations: [
        AvailabilityPageComponent,
        SlotComponent,
        TeamComponent,
        UserSlotComponent,
        GeneralComponent,
        EventDetailComponent,
        NewAvailabilityComponent,
        ScheduleComponent,
        ScheduleListItemComponent,
        EditAvailabilityPageComponent,
        NewAvailabilityPageComponent,
        ScheduleWeekComponent,
        NotificationEmailsComponent,
        QuestionsComponent,
        ScheduleDefinitionComponent,
        ScheduleExternalComponent,
        ExclusionDateComponent,
        ScheduleMonthComponent,
        CustomTimeComponent,
    ],
    providers: [PendingChangesGuard],
    imports: [
        CommonModule,
        SharedModule,
        AvailabilityRoutingModule,
        MaterialModule,
        SideMenuModule,
        HeaderModule,
        FormsModule,
        MomentTimezonePickerModule,
        CalendarModule.forRoot({
            provide: DateAdapter,
            useFactory: adapterFactory,
        }),
        ExclusionDatesModule,
    ],
})
export class AvailabilityModule {}
