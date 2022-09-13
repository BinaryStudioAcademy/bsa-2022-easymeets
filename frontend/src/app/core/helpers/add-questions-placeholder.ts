import { IQuestion } from '@core/models/IQuestion';

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
