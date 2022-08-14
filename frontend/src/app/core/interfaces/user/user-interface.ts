import { Country } from "@core/enums/country.enum";
import { DateFormat } from "@core/enums/date-format.enum";
import { Language } from "@core/enums/language.enum";
import { TimeFormat } from "@core/enums/time-format.enum";
import { TimeZone } from "@core/enums/time-zone.enum";

export interface IUser {
    id: number;
    image?: string;
    userName?: string;
    Language: Language;
    TimeFormat: TimeFormat;
    DateFormat: DateFormat;
    Country: Country;
    Phone?: string;
    TimeZone: TimeZone;
}
