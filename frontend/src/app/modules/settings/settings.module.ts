import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { CalendarModule } from '@modules/calendars/calendar.module';
import { HeaderModule } from '@modules/header/header.module';
import { SettingsPageComponent } from '@modules/settings/settings-page/settings-page.component';
import { SettingsRoutingModule } from '@modules/settings/settings-routing.module';
import { SideMenuModule } from '@modules/side-menu/side-menu.module';
import { MaterialModule } from '@shared/material/material.module';
import { SharedModule } from '@shared/shared.module';

@NgModule({
    declarations: [SettingsPageComponent],
    imports: [CommonModule, SettingsRoutingModule, SharedModule, MaterialModule, SideMenuModule, HeaderModule, CalendarModule],
})
export class SettingsModule { }
