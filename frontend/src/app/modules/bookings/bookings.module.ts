import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { HeaderModule } from '@modules/header/header.module';
import { SideMenuModule } from '@modules/side-menu/side-menu.module';
import { MaterialModule } from '@shared/material/material.module';

import { BookingsPageComponent } from './bookings-page/bookings-page.component';
import { BookingsRoutingModule } from './bookings-routing.module';

@NgModule({
    declarations: [BookingsPageComponent],
    imports: [CommonModule, BookingsRoutingModule, MaterialModule, SideMenuModule, HeaderModule],
})
export class BookingsModule {}
