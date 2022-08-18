import { Language } from '@shared/enums/language';

export const getLanguagesEnumsWithText = (): { enum: Language, text: string }[] => [
    {
        text: 'en',
        enum: Language.Eng,
    },
    {
        text: 'uk',
        enum: Language.Ukr,
    },
    {
        text: 'pl',
        enum: Language.Pl,
    },
    {
        text: 'fr',
        enum: Language.Fr,
    },
    {
        text: 'it',
        enum: Language.It,
    },
];

export const transformTextLanguageToEnum = (browserLanguage: string): Language =>
    getLanguagesEnumsWithText().find(lang => browserLanguage.includes(lang.text))?.enum ?? Language.Eng;
