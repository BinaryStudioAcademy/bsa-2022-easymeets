import { NgModule } from '@angular/core';
import { AngularFireModule } from '@angular/fire/compat';
import { AngularFireAuthModule } from '@angular/fire/compat/auth';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { CoreModule } from '@core/core.module';
import { environment } from '@env/environment';
import { MaterialModule } from '@shared/material/material.module';
import { SharedModule } from '@shared/shared.module';

import { AppComponent } from './app.component';
import { AppRoutingModule } from './app-routing.module';

@NgModule({
    declarations: [AppComponent],
    imports: [
        BrowserModule,
        BrowserAnimationsModule,
        CoreModule,
        SharedModule,
        AppRoutingModule,
        AngularFireModule.initializeApp(environment.firebase),
        AngularFireAuthModule,
        MaterialModule,
    ],
    providers: [],
    bootstrap: [AppComponent],
})
export class AppModule {}
