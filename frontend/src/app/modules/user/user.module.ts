import { NgModule } from '@angular/core';
import { UserRoutingModule } from '@modules/user/user-routing.module';
import { SharedModule } from '@shared/shared.module';

import { UserProfilePageComponent } from './user-profile-page/user-profile-page.component';

@NgModule({
    declarations: [
        UserProfilePageComponent,
    ],
    imports: [
        SharedModule,
        UserRoutingModule,
    ],
})
export class UserModule { }
