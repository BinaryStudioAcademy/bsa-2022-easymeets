import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MatDividerModule } from '@angular/material/divider';
import { MatInputModule } from '@angular/material/input';
import { MatRadioModule } from '@angular/material/radio';
import { MatSelectModule } from '@angular/material/select';

@NgModule({
    declarations: [],
    imports: [CommonModule, FormsModule, ReactiveFormsModule, MatSelectModule, MatInputModule, MatDividerModule, MatRadioModule],
    exports: [FormsModule, ReactiveFormsModule, CommonModule, MatSelectModule, MatInputModule, MatDividerModule, MatRadioModule],
})
export class MaterialModule {}
