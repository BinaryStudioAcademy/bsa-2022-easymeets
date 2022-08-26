import { IQuestion } from '@core/models/IQuestion';

export const getLocalMandatoryQuestions = (): IQuestion[] => [
    { questionText: 'Name', isMandatory: true },
    { questionText: 'Email', isMandatory: true },
];
