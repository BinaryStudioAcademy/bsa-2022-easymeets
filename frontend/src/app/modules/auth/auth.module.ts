import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AuthRoutingModule } from './auth-routing.module';
import { AuthPageComponent } from './auth-page/auth-page.component';
import { SignInFormComponent } from './sign-in-form/sign-in-form.component';
import { SignUpFormComponent } from './sign-up-form/sign-up-form.component';
import { AuthCardComponent } from './auth-card/auth-card.component';


@NgModule({
  declarations: [
    AuthPageComponent,
    SignInFormComponent,
    SignUpFormComponent,
    AuthCardComponent
  ],
  imports: [
    CommonModule,
    AuthRoutingModule
  ]
})
export class AuthModule { }
