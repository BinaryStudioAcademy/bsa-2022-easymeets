import { IQuestion } from '@core/models/IQuestion';

export const userFullNameQuestionText: string = 'Name and Surname *';
export const userFullNamePlaceHolder: string = 'Name Surname';
export const userEmailQuestionText: string = 'Your Email *';
export const userEmailPlaceHolder: string = 'booker@email.com';

export const getLocalMandatoryQuestions = (): IQuestion[] => [
    {
        id: 0,
        order: 0,
        questionText: userFullNameQuestionText,
        placeHolderText: userFullNamePlaceHolder,
        isMandatory: true,
        answer: '',
    },
    {
        id: 0,
        order: 1,
        questionText: userEmailQuestionText,
        placeHolderText: userEmailPlaceHolder,
        isMandatory: true,
        answer: '',
    },
];

export const addQuestionPlaceholder = (question: IQuestion): IQuestion => {
    switch (question.order) {
        case 0:
            return {
                ...question,
                placeHolderText: userFullNamePlaceHolder,
            };
        case 1:
            return {
                ...question,
                placeHolderText: userEmailPlaceHolder,
            };
        default:
            return {
                ...question,
                placeHolderText: '',
            };
    }
};
