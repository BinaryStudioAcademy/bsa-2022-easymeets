import { NgModule } from '@angular/core';
import { MatIconModule } from '@angular/material/icon';
import { MatTableModule } from '@angular/material/table';
import { MaterialModule } from '@shared/material/material.module';

import { CalendarsPageComponent } from './calendars-page/calendars-page.component';
import { CalendarRoutingModule } from './calendar-routing.module';

@NgModule({
    declarations: [CalendarsPageComponent],
    imports: [CalendarRoutingModule, MaterialModule, MatTableModule, MatIconModule],
})
export class CalendarModule {}
