import { AbstractControl, ValidationErrors, ValidatorFn } from '@angular/forms';
import { DayAction } from '@core/enums/day-action.enum';

export const TimeRangeValidator =
    (firstControl: AbstractControl): ValidatorFn =>
        (control: AbstractControl): ValidationErrors | null =>
            (firstControl?.value < control?.value ? null : { error: true });

export function normalizeHours(hours: number): [number, DayAction] {
    if (hours < 0) {
        return [24 + hours, DayAction.SubtractDay];
    }
    if (hours >= 24) {
        return [hours - 24, DayAction.AddDay];
    }

    return [hours, DayAction.NoAction];
}

export const getTimeString = (hours: number, minutes: string) =>
    `${hours.toString().length < 2 ? '0' : ''}${hours}:${minutes}`;

export function convertTimeToOffset(time: string, offsetValue: string): [number, string, DayAction] {
    const offsetHours = Number(offsetValue.substring(0, 3));
    const hours = Number(time.substring(0, 2));
    const minutes = time.substring(3, 5);
    const hoursConverted = hours + offsetHours;

    const [correctHours, hoursDayAction] = normalizeHours(hoursConverted);

    return [correctHours, minutes, hoursDayAction];
}

export const changeOffsetSign = (offset: string) =>
    (offset[0] === '+' ? offset.replace(/\+/g, '-') : offset.replace(/-/g, '+'));
