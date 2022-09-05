import { Country } from '@shared/enums/country';
import { DateFormat } from '@shared/enums/dateFormat';
import { Language } from '@shared/enums/language';
import { TimeFormat } from '@shared/enums/timeFormat';

import { ITimeZone } from './ITimeZone';

export interface IUpdateUser {
    id: number;
    userName: string;
    language: Language;
    timeFormat: TimeFormat;
    dateFormat: DateFormat;
    country?: Country;
    phoneCode?: string;
    phone?: string;
    timeZone: ITimeZone;
}
