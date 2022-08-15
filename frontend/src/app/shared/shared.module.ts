import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MatIconRegistry } from '@angular/material/icon';
import { DomSanitizer } from '@angular/platform-browser';
import { MatButtonModule } from '@angular/material/button';
import { MatDialogModule } from '@angular/material/dialog';
import { RouterModule } from '@angular/router';

import { ConfirmationWindowComponent } from './components/confirmation-window/confirmation-window.component';
import { LoadingSpinnerComponent } from './components/loading-spinner/loading-spinner.component';
import { NotFoundComponent } from './components/not-found/not-found.component';

@NgModule({
    imports: [CommonModule, RouterModule, FormsModule, ReactiveFormsModule, RouterModule, MatDialogModule, MatButtonModule],
    declarations: [LoadingSpinnerComponent, NotFoundComponent, ConfirmationWindowComponent],
    exports: [
        CommonModule,
        RouterModule,
        FormsModule,
        ReactiveFormsModule,
        RouterModule,
        LoadingSpinnerComponent,
        NotFoundComponent,
        ConfirmationWindowComponent,
    ],
})
export class SharedModule {
    constructor(sanitizer: DomSanitizer, matIconRegistry: MatIconRegistry) {
        matIconRegistry.addSvgIcon(
            'google-logo',
            sanitizer.bypassSecurityTrustResourceUrl('./assets/icons/google-logo.svg'),
        );
    }
}
