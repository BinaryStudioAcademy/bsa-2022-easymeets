import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MatIconRegistry } from '@angular/material/icon';
import { DomSanitizer } from '@angular/platform-browser';
import { RouterModule } from '@angular/router';

import { LoadingSpinnerComponent } from './components/loading-spinner/loading-spinner.component';
import { NotFoundComponent } from './components/not-found/not-found.component';

@NgModule({
    imports: [CommonModule, RouterModule, FormsModule, ReactiveFormsModule, RouterModule],
    declarations: [LoadingSpinnerComponent, NotFoundComponent],
    exports: [
        CommonModule,
        RouterModule,
        FormsModule,
        ReactiveFormsModule,
        RouterModule,
        LoadingSpinnerComponent,
        NotFoundComponent,
    ],
})
export class SharedModule {
    constructor(sanitizer: DomSanitizer, matIconRegistry: MatIconRegistry) {
        matIconRegistry.addSvgIcon(
            'google-sign-in',
            sanitizer.bypassSecurityTrustResourceUrl('./assets/icons/google-logo.svg'),
        );
    }
}
