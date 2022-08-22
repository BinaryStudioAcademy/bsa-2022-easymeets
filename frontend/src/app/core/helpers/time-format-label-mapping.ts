import { TimeFormat } from '@shared/enums/timeFormat';

export const TimeFormatLabelMapping: Record<TimeFormat, string> = {
    [TimeFormat.TwelveHour]: '12h',
    [TimeFormat.TwentyFourHour]: '24h',
};
