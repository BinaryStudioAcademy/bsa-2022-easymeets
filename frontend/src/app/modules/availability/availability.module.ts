import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';

import { EventDetailComponent } from './new-slot/event-detail/event-detail.component';

@NgModule({
    declarations: [
        EventDetailComponent,
    ],
    imports: [
        CommonModule,
    ],
})
export class AvailabilityModule { }
