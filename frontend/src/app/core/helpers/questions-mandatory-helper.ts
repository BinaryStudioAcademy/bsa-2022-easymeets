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

export const addQuestionPlaceholder = (question: IQuestion): IQuestion => {
    switch (question.order) {
        case 0:
            return {
                ...question,
                placeHolderText: 'Name Surname',
            };
        case 1:
            return {
                ...question,
                placeHolderText: 'booker@email.com',
            };
        default:
            return {
                ...question,
                placeHolderText: '',
            };
    }
};
