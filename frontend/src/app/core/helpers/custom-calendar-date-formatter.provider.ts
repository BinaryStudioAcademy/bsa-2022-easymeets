import { formatDate } from '@angular/common';
import { Injectable } from '@angular/core';
import { CalendarDateFormatter, DateFormatterParams } from 'angular-calendar';

@Injectable()
export class CustomCalendarDateFormatter extends CalendarDateFormatter {
    public override weekViewColumnHeader({ date, locale }: DateFormatterParams): string {
        return formatDate(date, 'EEE', locale!);
    }

    public override weekViewColumnSubHeader({ date, locale }: DateFormatterParams): string {
        return formatDate(date, 'd', locale!);
    }

    public override monthViewColumnHeader({ date, locale }: DateFormatterParams): string {
        return formatDate(date, 'EEE', locale!);
    }
}
