import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { CalendarsPageComponent } from './calendars-page/calendars-page.component';

const routes: Routes = [
    {
        path: '',
        component: CalendarsPageComponent,
    },
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule],
})
export class CalendarRoutingModule {}
