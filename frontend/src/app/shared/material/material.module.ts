import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MatSelectModule } from '@angular/material/select';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

export { MatSelectModule } from '@angular/material/select';

@NgModule({
    declarations: [],
    imports: [CommonModule, FormsModule, ReactiveFormsModule, MatSelectModule, BrowserAnimationsModule],
    exports: [FormsModule, ReactiveFormsModule, CommonModule, MatSelectModule, BrowserAnimationsModule],
})
export class MaterialModule {}
