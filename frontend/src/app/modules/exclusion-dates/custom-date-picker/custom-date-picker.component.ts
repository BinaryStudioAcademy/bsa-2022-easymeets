import {
    Component, ElementRef,
    EventEmitter,
    Input,
    Output,
    ViewEncapsulation,
} from '@angular/core';
import { DateAdapter, MAT_DATE_FORMATS, MAT_DATE_LOCALE, MAT_NATIVE_DATE_FORMATS } from '@angular/material/core';
import { MatCalendarCellClassFunction } from '@angular/material/datepicker';
import { CustomDateAdapter } from '@modules/exclusion-dates/custom-date-adapter';
import { HeaderDatePickerComponent } from '@modules/exclusion-dates/header-date-picker/header-date-picker.component';

@Component({
    selector: 'app-custom-date-picker',
    templateUrl: './custom-date-picker.component.html',
    styleUrls: ['./custom-date-picker.component.sass'],
    encapsulation: ViewEncapsulation.None,
    providers: [
        { provide: DateAdapter, useClass: CustomDateAdapter, deps: [MAT_DATE_LOCALE] },
        { provide: MAT_DATE_FORMATS, useValue: MAT_NATIVE_DATE_FORMATS },
    ],
})
export class CustomDatePickerComponent {
    todayDate: Date;

    @Input() selected: Date | null;

    @Output() selectedChange = new EventEmitter<Date | null>();

    customHeader = HeaderDatePickerComponent;

    constructor(private element: ElementRef) {
        this.todayDate = new Date();
        this.todayDate.setHours(0, 0, 0, 0);
    }

    dateClass: MatCalendarCellClassFunction<Date> = (cellDate, view) => {
        if (view === 'month') {
            cellDate.setHours(0, 0, 0, 0);

            return cellDate >= this.todayDate ? 'cell ordinary' : 'cell';
        }

        return '';
    };
}
