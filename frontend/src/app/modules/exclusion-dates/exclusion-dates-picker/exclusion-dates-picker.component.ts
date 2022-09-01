import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import { MatCalendarCellClassFunction } from "@angular/material/datepicker";

@Component({
  selector: 'app-exclusion-dates-picker',
  templateUrl: './exclusion-dates-picker.component.html',
  styleUrls: ['./exclusion-dates-picker.component.sass'],
    encapsulation: ViewEncapsulation.None,
})
export class ExclusionDatesPickerComponent implements OnInit {

    todayDate:Date = new Date();
    selected: Date | null;
    dateClass: MatCalendarCellClassFunction<Date> = (cellDate, view) => {
        console.log(this.selected)
        if (view === 'month') {
            let selectedDate = new Date(cellDate.getFullYear(), cellDate.getMonth(), cellDate.getDate());
            if (selectedDate.getDate() === this.todayDate.getDate() &&
                selectedDate.getMonth() === this.todayDate.getMonth() &&
                selectedDate.getFullYear() === this.todayDate.getFullYear()) {
                return 'current-day cell';
            }
            if (selectedDate.getDate() === this.selected?.getDate() &&
                selectedDate.getMonth() === this.selected?.getMonth() &&
                selectedDate.getFullYear() === this.selected?.getFullYear()) {
                console.log(selectedDate)
                console.log(cellDate)
                return 'selected-day cell';
            }
            if (selectedDate >= this.todayDate) {
                return 'test-class cell';
            }
        }

        return '';
    };
  constructor() { }

  ngOnInit(): void {
  }

}
