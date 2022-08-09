import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MatInputModule } from '@angular/material/input';
import { MatSelectModule } from '@angular/material/select';

@NgModule({
    declarations: [],
    imports: [CommonModule, FormsModule, ReactiveFormsModule, MatSelectModule, MatInputModule],
    exports: [FormsModule, ReactiveFormsModule, CommonModule, MatSelectModule, MatInputModule],
})
export class MaterialModule {}
