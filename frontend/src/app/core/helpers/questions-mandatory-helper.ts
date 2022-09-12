import { IQuestion } from '@core/models/IQuestion';

export const getLocalMandatoryQuestions = (): IQuestion[] => [
    {
        id: 0,
        order: 0,
        questionText: 'Name and Surname *',
        placeHolderText: 'Name Surname',
        isMandatory: true,
    },
    {
        id: 0,
        order: 0,
        questionText: 'Your Email *',
        placeHolderText: 'booker@email.com',
        isMandatory: true,
    },
];
