import { Language } from '@shared/enums/language';

export const getLanguageEnum = (userLanguageBrowser: string) => {
    let userLanguage: Language = Language.Eng;

    const languages: { enum: Language, text: string } [] = [
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

    languages.forEach(lang => {
        if (userLanguageBrowser.includes(lang.text)) {
            userLanguage = lang.enum;
        }
    });

    return userLanguage;
};
