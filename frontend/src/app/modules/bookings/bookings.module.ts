import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { HeaderModule } from '@modules/header/header.module';
import { SideMenuModule } from '@modules/side-menu/side-menu.module';
import { MaterialModule } from '@shared/material/material.module';

import { BookerComponent } from './booker/booker.component';
import { BookersPageComponent } from './bookers-page/bookers-page.component';
import { BookingsPageComponent } from './bookings-page/bookings-page.component';
import { ExternalAttendeeAnswersComponent } from './external-attendee-answers/external-attendee-answers.component';
import { BookingsRoutingModule } from './bookings-routing.module';

@NgModule({
    declarations: [BookingsPageComponent, BookersPageComponent, BookerComponent, ExternalAttendeeAnswersComponent],
    imports: [CommonModule, BookingsRoutingModule, MaterialModule, SideMenuModule, HeaderModule],
})
export class BookingsModule {}
