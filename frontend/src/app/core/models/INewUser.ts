import { Country } from '@shared/enums/country';
import { DateFormat } from '@shared/enums/dateFormat';
import { Language } from '@shared/enums/language';
import { TimeFormat } from '@shared/enums/timeFormat';

export interface INewUser {
    uid?: string;
    userName: string
    email: string
    image?: string
    language: Language
    timeFormat: TimeFormat
    dateFormat: DateFormat
    country?: Country
    phone?: string
    timeZone: number
}
