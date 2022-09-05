import { Language } from '@shared/enums/language';

export const getLanguagesEnumsWithText = () => [
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

export const getLanguage = (): Language => {
    const userLanguageBrowser =
        navigator.languages && navigator.languages.length ? navigator.languages[0] : navigator.language;

    return transformTextLanguageToEnum(userLanguageBrowser);
};
