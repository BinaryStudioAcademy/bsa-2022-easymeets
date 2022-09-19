import { AbstractControl, ValidationErrors, ValidatorFn } from '@angular/forms';
import { DayAction } from '@core/enums/day-action.enum';
import { ITimeOnly } from '@core/models/ITimeOnly';

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

export function convertTimeToOffset(time: ITimeOnly, offsetValue: string): [ITimeOnly, DayAction] {
    const offsetHours = Number(offsetValue.substring(0, 3));
    const hoursConverted = (time.hour + offsetHours + 24) % 24;

    return [{ hour: hoursConverted, minute: time.minute }, getDayAction(time.hour, offsetHours)];
}

export const changeOffsetSign = (offset: string) =>
    (offset[0] === '+' ? offset.replace(/\+/g, '-') : offset.replace(/-/g, '+'));
