import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { MatCardModule } from '@angular/material/card';

@NgModule({
    declarations: [],
    imports: [CommonModule, FormsModule, ReactiveFormsModule, MatCardModule, MatButtonModule],
    exports: [FormsModule, ReactiveFormsModule, CommonModule, MatCardModule, MatButtonModule],
})
export class MaterialModule {}
