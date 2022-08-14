import { NgModule } from '@angular/core';
import { MaterialModule } from '@shared/material/material.module';

import { CalendarsPageComponent } from './calendars-page/calendars-page.component';
import { CalendarRoutingModule } from './calendar-routing.module';

@NgModule({
    declarations: [CalendarsPageComponent],
    imports: [CalendarRoutingModule, MaterialModule],
})
export class CalendarModule {}
