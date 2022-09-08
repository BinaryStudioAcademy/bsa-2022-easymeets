import {
    ChangeDetectionStrategy,
    ChangeDetectorRef,
    Component,
    Inject,
} from '@angular/core';
import { DateAdapter, MAT_DATE_FORMATS, MatDateFormats } from '@angular/material/core';
import { MatCalendar } from '@angular/material/datepicker';
import { BaseComponent } from '@core/base/base.component';

@Component({
    selector: 'app-header-date-picker',
    styleUrls: ['./header-date-picker.component.sass'],
    templateUrl: './header-date-picker.component.html',
    changeDetection: ChangeDetectionStrategy.OnPush,
})
export class HeaderDatePickerComponent<D> extends BaseComponent {
    constructor(
        private calendar: MatCalendar<D>,
        private dateAdapter: DateAdapter<D>,
        @Inject(MAT_DATE_FORMATS) private dateFormats: MatDateFormats,
        cdr: ChangeDetectorRef,
    ) {
        super();
        calendar.stateChanges
            .pipe(this.untilThis)
            .subscribe(() => cdr.markForCheck());
    }

    get periodLabel() {
        return this.dateAdapter
            .format(this.calendar.activeDate, this.dateFormats.display.monthYearA11yLabel);
    }

    previousClicked() {
        this.dateAdapter.addCalendarMonths(this.calendar.activeDate, -1);
    }

    nextClicked() {
        this.dateAdapter.addCalendarMonths(this.calendar.activeDate, 1);
    }
}
