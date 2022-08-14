import { NgModule } from '@angular/core';
import { HeaderModule } from '@modules/header/header.module';
import { UserRoutingModule } from '@modules/user/user-routing.module';
import { MaterialModule } from '@shared/material/material.module';
import { SharedModule } from '@shared/shared.module';

import { UserProfilePageComponent } from './user-profile-page/user-profile-page.component';

@NgModule({
    declarations: [
        UserProfilePageComponent,
    ],
    imports: [
        SharedModule,
        UserRoutingModule,
        MaterialModule,
        HeaderModule,
    ],
})
export class UserModule { }
