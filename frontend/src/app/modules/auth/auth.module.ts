import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { MaterialModule } from '@shared/material/material.module';
import { SharedModule } from '@shared/shared.module';

import { AuthCardComponent } from './components/auth-card/auth-card.component';
import { AuthPageComponent } from './components/auth-page/auth-page.component';
import { ForgotFormComponent } from './components/forgot-form/forgot-form.component';
import { RecoveryCodeFormComponent } from './components/recovery-code-form/recovery-code-form.component';
import { SignInFormComponent } from './components/sign-in-form/sign-in-form.component';
import { SignUpFormComponent } from './components/sign-up-form/sign-up-form.component';
import { AuthRoutingModule } from './auth-routing.module';

@NgModule({
    declarations: [
        AuthPageComponent,
        SignInFormComponent,
        SignUpFormComponent,
        ForgotFormComponent,
        AuthCardComponent,
        RecoveryCodeFormComponent,
    ],
    imports: [
        CommonModule,
        AuthRoutingModule,
        SharedModule,
        MaterialModule,
    ],
})
export class AuthModule {}
