import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { MatSnackBarModule } from '@angular/material/snack-bar';

@NgModule({
    declarations: [],
    imports: [CommonModule, FormsModule, ReactiveFormsModule, MatButtonModule, MatSnackBarModule],
    exports: [FormsModule, ReactiveFormsModule, CommonModule, MatButtonModule, MatSnackBarModule],
})
export class MaterialModule {}
