import { DatePipe } from '@angular/common';
import { Pipe, PipeTransform } from '@angular/core';
import { ITimeZone } from '@core/models/ITimeZone';
import * as moment from 'moment-timezone';

@Pipe({ name: 'exclusionTime' })
export class ExclusionTimePipe implements PipeTransform {
    // eslint-disable-next-line no-empty-function
    constructor(public datePipe: DatePipe) {}

    transform(dateTime: string, timeZone: ITimeZone, date: string): string | null {
        const momentDateTimeStart = moment(dateTime).tz(timeZone.nameValue).startOf('day').toDate();
        const momentDateStart = moment(date).tz(timeZone.nameValue).startOf('day').toDate();

        if (momentDateStart < momentDateTimeStart) {
            return '23:59';
        }
        if (momentDateStart > momentDateTimeStart) {
            return '00:00';
        }

        return this.datePipe.transform(dateTime, 'HH:mm', timeZone.timeValue);
    }
}
