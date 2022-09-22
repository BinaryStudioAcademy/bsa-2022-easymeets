import { AbstractControl, ValidationErrors, ValidatorFn } from '@angular/forms';
import { ITimeOnly } from '@core/models/ITimeOnly';
import * as moment from 'moment-timezone';

export const TimeRangeValidator =
    (firstControl: AbstractControl): ValidatorFn =>
        (control: AbstractControl): ValidationErrors | null =>
            (firstControl?.value < control?.value ? null : { error: true });

export const getTimeZoneHours = (timeZoneValue: string) => Number(timeZoneValue.substring(0, 3));

export const getTimeOnlyFromString = (time: string): ITimeOnly => ({
    hour: Number(time.substring(0, 2)),
    minute: Number(time.substring(3, 5)),
});

export const getFullDayTimeRange = () => ({ start: { hour: 0, minute: 0 }, end: { hour: 23, minute: 59 } });

export const getMillisecondsFromDateString = (date: string) => moment.utc(date).toDate().getTime();

export const getDateStringWithTimeZone = (date: string, timeZoneNameValue: string) =>
    moment.utc(date).tz(timeZoneNameValue).format();
