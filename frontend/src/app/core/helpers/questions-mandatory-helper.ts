import { IQuestion } from '@core/models/IQuestion';

export const getLocalMandatoryQuestions = (): IQuestion[] => [
    { id: 0, questionText: 'Name', isMandatory: true },
    { id: 1, questionText: 'Email', isMandatory: true },
];
