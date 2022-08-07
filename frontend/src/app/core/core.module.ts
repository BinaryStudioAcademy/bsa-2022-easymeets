import { HTTP_INTERCEPTORS, HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { AngularFireModule } from '@angular/fire/compat';
import { AngularFireAuthModule } from '@angular/fire/compat/auth';
import { environment } from '@env/environment';
import { SharedModule } from '@shared/shared.module';

import { BaseComponent } from './base/base.component';
import { ErrorInterceptor } from './interceptors/error.interceptor';

@NgModule({
    imports: [HttpClientModule, SharedModule, AngularFireModule.initializeApp(environment.firebase), AngularFireAuthModule],
    providers: [{ provide: HTTP_INTERCEPTORS, useClass: ErrorInterceptor, multi: true }],
    declarations: [BaseComponent],
})
export class CoreModule {}
