import { AbstractControl, ValidationErrors, ValidatorFn } from '@angular/forms';
import { DayAction } from '@core/enums/day-action.enum';

export const TimeRangeValidator =
    (firstControl: AbstractControl): ValidatorFn =>
        (control: AbstractControl): ValidationErrors | null =>
            (firstControl?.value < control?.value ? null : { error: true });

export function getDayAction(hours: number, offsetHours: number): DayAction {
    if (hours + offsetHours < 0) {
        return DayAction.SubtractDay;
    }
    if (hours + offsetHours >= 24) {
        return DayAction.AddDay;
    }

    return DayAction.NoAction;
}

export const getTimeString = (hours: number, minutes: string) =>
    `${hours.toString().length < 2 ? '0' : ''}${hours}:${minutes}`;

export function convertTimeToOffset(time: string, offsetValue: string): [number, string, DayAction] {
    const offsetHours = Number(offsetValue.substring(0, 3));
    const hours = Number(time.substring(0, 2));
    const minutes = time.substring(3, 5);
    const hoursConverted = (hours + offsetHours + 24) % 24;

    return [hoursConverted, minutes, getDayAction(hours, offsetHours)];
}

export const changeOffsetSign = (offset: string) =>
    (offset[0] === '+' ? offset.replace(/\+/g, '-') : offset.replace(/-/g, '+'));
