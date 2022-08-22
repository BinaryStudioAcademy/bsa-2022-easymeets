import { DateFormat } from '@shared/enums/dateFormat';

export const DateFormatLabelMapping: Record<DateFormat, string> = {
    [DateFormat.MonthDayYear]: 'MM/DD/YYYY ',
    [DateFormat.DayMonthYear]: 'DD/MM/YYYY',
};
