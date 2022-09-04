import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { MatCardModule } from '@angular/material/card';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { MatIconModule } from '@angular/material/icon';

import { ExclusionDatesPickerComponent } from './exclusion-dates-picker/exclusion-dates-picker.component';
import { HeaderDatePickerComponent } from './header-date-picker/header-date-picker.component';

@NgModule({
    declarations: [
        ExclusionDatesPickerComponent,
        HeaderDatePickerComponent,
    ],
    exports: [
        ExclusionDatesPickerComponent,
    ],
    imports: [
        CommonModule,
        MatButtonModule,
        MatDatepickerModule,
        MatCardModule,
        MatIconModule,
        ReactiveFormsModule,
    ],
})
export class ExclusionDatesModule { }
