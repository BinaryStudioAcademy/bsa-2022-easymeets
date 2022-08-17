import { NgModule } from '@angular/core';
import { CalendarModule } from '@modules/calendars/calendar.module';
import { HeaderModule } from '@modules/header/header.module';
import { UserRoutingModule } from '@modules/user/user-routing.module';
import { MaterialModule } from '@shared/material/material.module';
import { SharedModule } from '@shared/shared.module';
import { UserProfilePageComponent } from './user-profile-page/user-profile-page.component';
import { UserSettingsPageComponent } from './user-settings-page/user-settings-page.component';
import { SideMenuModule } from "@modules/side-menu/side-menu.module";

@NgModule({
    declarations: [UserProfilePageComponent, UserSettingsPageComponent],
    imports: [SharedModule, UserRoutingModule, MaterialModule, SideMenuModule, HeaderModule, CalendarModule],
})
export class UserModule {}
