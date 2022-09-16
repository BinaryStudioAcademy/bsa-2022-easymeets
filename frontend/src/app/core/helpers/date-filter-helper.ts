import { DateFilterValue } from '@shared/enums/dateFilterValue';

export const getDateFilters = (): DateFilterValue[] => [
    DateFilterValue.Today,
    DateFilterValue.Past,
    DateFilterValue.Pending,
    DateFilterValue.Range,
];
