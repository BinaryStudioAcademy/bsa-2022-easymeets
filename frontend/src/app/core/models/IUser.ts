import { Country } from '@shared/enums/country';
import { DateFormat } from '@shared/enums/dateFormat';
import { Language } from '@shared/enums/language';
import { TimeFormat } from '@shared/enums/timeFormat';

import { ITimeZone } from './ITimeZone';

export interface IUser {
    id: bigint;
    uid?: string;
    userName: string;
    personalUrl: string;
    email: string;
    image?: string;
    language: Language;
    timeFormat: TimeFormat;
    dateFormat: DateFormat;
    country?: Country;
    phoneCode?: string;
    phone?: string;
    timeZone: ITimeZone;
}

export interface ILocalUser {
    id: bigint;
    uid?: string;
    userName: string;
    image?: string;
    timeZone?: ITimeZone;
    timeFormat?: TimeFormat;
}
