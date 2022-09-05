import { NgModule } from '@angular/core';
import { UserRoutingModule } from '@modules/settings/user/user-routing.module';
import { MaterialModule } from '@shared/material/material.module';
import { SharedModule } from '@shared/shared.module';
import { MomentTimezonePickerModule } from 'moment-timezone-picker';

import { UserProfilePageComponent } from './user-profile-page/user-profile-page.component';

@NgModule({
    declarations: [UserProfilePageComponent],
    imports: [SharedModule, UserRoutingModule, MaterialModule, MomentTimezonePickerModule],
})
export class UserModule {}
