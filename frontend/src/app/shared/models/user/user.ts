import { Country } from '@shared/enums/country';
import { DateFormat } from '@shared/enums/dateFormat';
import { Language } from '@shared/enums/language';
import { TimeFormat } from '@shared/enums/timeFormat';
import { TimeZone } from '@shared/enums/timeZone';

export interface User {
    id: number
    image?: string
    userName?: string
    language: Language
    timeFormat: TimeFormat
    dateFormat: DateFormat
    country: Country
    phone?: string
    timeZone: TimeZone
}
