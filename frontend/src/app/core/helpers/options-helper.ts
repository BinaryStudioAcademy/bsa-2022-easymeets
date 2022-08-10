import { ICheckOption } from '@core/interfaces/check-option';

export const getDefaultOptions = (): ICheckOption[] => [
    { name: 'Yes', value: true },
    { name: 'No', value: false },
];
