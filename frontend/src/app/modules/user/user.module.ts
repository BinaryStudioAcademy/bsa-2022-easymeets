import { NgModule } from '@angular/core';
import { SideMenuModule } from '@modules/side-menu/side-menu.module';
import { UserRoutingModule } from '@modules/user/user-routing.module';
import { MaterialModule } from '@shared/material/material.module';
import { SharedModule } from '@shared/shared.module';

import { UserProfilePageComponent } from './user-profile-page/user-profile-page.component';
import { UserSettingsPageComponent } from './user-settings-page/user-settings-page.component';

@NgModule({
    declarations: [UserProfilePageComponent, UserSettingsPageComponent],
    imports: [SharedModule, UserRoutingModule, MaterialModule, SideMenuModule],
})
export class UserModule {}
