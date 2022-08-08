import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { MatCardModule } from '@angular/material/card';
import { MatSlideToggleModule } from '@angular/material/slide-toggle';

@NgModule({
    declarations: [],
    imports: [CommonModule, FormsModule, ReactiveFormsModule, MatCardModule, MatButtonModule, MatSlideToggleModule],
    exports: [FormsModule, ReactiveFormsModule, CommonModule, MatCardModule, MatButtonModule, MatSlideToggleModule],
})
export class MaterialModule {}
