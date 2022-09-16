import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { MatCardModule } from '@angular/material/card';
import { DateAdapter, MAT_DATE_LOCALE } from '@angular/material/core';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { MatIconModule } from '@angular/material/icon';
import { CustomDateAdapter } from '@modules/exclusion-dates/custom-date-adapter';

import { CustomDatePickerComponent } from './custom-date-picker/custom-date-picker.component';
import { ExclusionDatesPickerComponent } from './exclusion-dates-picker/exclusion-dates-picker.component';
import { HeaderDatePickerComponent } from './header-date-picker/header-date-picker.component';

@NgModule({
    declarations: [ExclusionDatesPickerComponent, HeaderDatePickerComponent, CustomDatePickerComponent],
    exports: [ExclusionDatesPickerComponent, HeaderDatePickerComponent, CustomDatePickerComponent],
    imports: [CommonModule, MatButtonModule, MatCardModule, MatIconModule, ReactiveFormsModule, MatDatepickerModule],
    providers: [{ provide: DateAdapter, useClass: CustomDateAdapter, deps: [MAT_DATE_LOCALE] }],
})
export class ExclusionDatesModule {}
