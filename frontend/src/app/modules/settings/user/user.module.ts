import { NgModule } from '@angular/core';
import { UserRoutingModule } from '@modules/settings/user/user-routing.module';
import { MaterialModule } from '@shared/material/material.module';
import { SharedModule } from '@shared/shared.module';

import { UserProfilePageComponent } from './user-profile-page/user-profile-page.component';

@NgModule({
    declarations: [UserProfilePageComponent],
    imports: [SharedModule, UserRoutingModule, MaterialModule],
})
export class UserModule {}
