import { IQuestion } from '@core/models/IQuestion';

export const getLocalMandatoryQuestions = (): IQuestion[] => [
    {
        id: 0,
        order: 0,
        questionText: 'Name and Surname *',
        placeHolderText: 'Name Surname',
        checkboxText: 'Autofill Invitee Name, Email',
        isMandatory: true,
    },
    {
        id: 0,
        order: 0,
        questionText: 'Your Email *',
        placeHolderText: 'booker@email.com',
        checkboxText: 'Allow Booker to add additional guests',
        isMandatory: true,
    },
];
