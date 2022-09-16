import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { MatChipsModule } from '@angular/material/chips';
import { MatDialogModule } from '@angular/material/dialog';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatIconModule, MatIconRegistry } from '@angular/material/icon';
import { DomSanitizer } from '@angular/platform-browser';
import { RouterModule } from '@angular/router';
import { NgxMaskModule } from 'ngx-mask';

import { BookingWindowComponent } from './components/booking-window/booking-window.component';
import { ConfirmationWindowComponent } from './components/confirmation-window/confirmation-window.component';
import { LoadingSpinnerComponent } from './components/loading-spinner/loading-spinner.component';
import { NotFoundComponent } from './components/not-found/not-found.component';
import { OwnerRightsWindowComponent } from './components/owner-rights-window/owner-rights-window.component';
import { TeamMembersWindowComponent } from './components/team-members-window/team-members-window.component';
import { UnsavedChangesComponent } from './components/unsaved-changes/unsaved-changes.component';
import { HeaderLessTabsDirective } from './directives/header-less-tabs.directive';

@NgModule({
    imports: [
        CommonModule,
        RouterModule,
        FormsModule,
        ReactiveFormsModule,
        RouterModule,
        MatDialogModule,
        MatButtonModule,
        NgxMaskModule,
        MatChipsModule,
        MatFormFieldModule,
        MatIconModule,
    ],
    declarations: [
        LoadingSpinnerComponent,
        NotFoundComponent,
        ConfirmationWindowComponent,
        HeaderLessTabsDirective,
        UnsavedChangesComponent,
        BookingWindowComponent,
        TeamMembersWindowComponent,
        OwnerRightsWindowComponent,
    ],
    exports: [
        CommonModule,
        RouterModule,
        FormsModule,
        ReactiveFormsModule,
        RouterModule,
        LoadingSpinnerComponent,
        NotFoundComponent,
        ConfirmationWindowComponent,
        UnsavedChangesComponent,
        NgxMaskModule,
        HeaderLessTabsDirective,
        MatChipsModule,
        MatFormFieldModule,
        MatIconModule,
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
