import { ICheckOption } from '@core/interfaces/check-option-interface';

export const getDefaultOptions = (): ICheckOption[] => [
    { name: 'Yes', value: true },
    { name: 'No', value: false },
];
