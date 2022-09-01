import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ExclusionDatesPickerComponent } from './exclusion-dates-picker/exclusion-dates-picker.component';
import { MatButtonModule } from "@angular/material/button";
import { MatDatepickerModule } from "@angular/material/datepicker";
import { MatCardModule } from "@angular/material/card";
import { HeaderDatePickerComponent } from './header-date-picker/header-date-picker.component';
import { MatIconModule } from "@angular/material/icon";



@NgModule({
    declarations: [
        ExclusionDatesPickerComponent,
        HeaderDatePickerComponent
    ],
    exports: [
        ExclusionDatesPickerComponent
    ],
    imports: [
        CommonModule,
        MatButtonModule,
        MatDatepickerModule,
        MatCardModule,
        MatIconModule
    ]
})
export class ExclusionDatesModule { }
