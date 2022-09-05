import { Component, EventEmitter, Input, Output, ViewEncapsulation } from '@angular/core';
import { MatCalendarCellClassFunction } from '@angular/material/datepicker';
import { HeaderDatePickerComponent } from '@modules/exclusion-dates/header-date-picker/header-date-picker.component';

@Component({
    selector: 'app-custom-date-picker',
    templateUrl: './custom-date-picker.component.html',
    styleUrls: ['./custom-date-picker.component.sass'],
    encapsulation: ViewEncapsulation.None,
})
export class CustomDatePickerComponent {
    todayDate: Date = new Date();

    @Input() selected: Date | null;

    @Output() selectedChange = new EventEmitter<Date | null>();

    customHeader = HeaderDatePickerComponent;

    dateClass: MatCalendarCellClassFunction<Date> = (cellDate, view) => {
        if (view === 'month') {
            const selectedDate = new Date(cellDate.getFullYear(), cellDate.getMonth(), cellDate.getDate());

            if (selectedDate.getDate() === this.todayDate.getDate() &&
                selectedDate.getMonth() === this.todayDate.getMonth() &&
                selectedDate.getFullYear() === this.todayDate.getFullYear()) {
                return 'current-day cell';
            }
            if (selectedDate.getDate() === this.selected?.getDate() &&
                selectedDate.getMonth() === this.selected?.getMonth() &&
                selectedDate.getFullYear() === this.selected?.getFullYear()) {
                return 'selected-day cell';
            }
            if (selectedDate >= this.todayDate) {
                return 'test-class cell';
            }
        }

        return '';
    };
}
