import { Country } from '@shared/enums/country';
import { DateFormat } from '@shared/enums/dateFormat';
import { Language } from '@shared/enums/language';
import { TimeFormat } from '@shared/enums/timeFormat';

export interface IUpdateUser {
    id: bigint;
    userName: string;
    language: Language;
    timeFormat: TimeFormat;
    dateFormat: DateFormat;
    country?: Country;
    phoneCode?: string;
    phone?: string;
}
