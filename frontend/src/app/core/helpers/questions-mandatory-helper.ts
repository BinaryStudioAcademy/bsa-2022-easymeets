import { IQuestion } from '@core/models/IQuestion';

export const getLocalMandatoryQuestions = (): IQuestion[] => [
    { id: 0, order: 0, questionText: 'Name', isMandatory: true },
    { id: 0, order: 0, questionText: 'Email', isMandatory: true },
];
