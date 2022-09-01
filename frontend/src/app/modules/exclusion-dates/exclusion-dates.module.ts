import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ExclusionDatesPickerComponent } from './exclusion-dates-picker/exclusion-dates-picker.component';
import { MatButtonModule } from "@angular/material/button";
import { MatDatepickerModule } from "@angular/material/datepicker";
import { MatCardModule } from "@angular/material/card";



@NgModule({
    declarations: [
        ExclusionDatesPickerComponent
    ],
    exports: [
        ExclusionDatesPickerComponent
    ],
    imports: [
        CommonModule,
        MatButtonModule,
        MatDatepickerModule,
        MatCardModule
    ]
})
export class ExclusionDatesModule { }
