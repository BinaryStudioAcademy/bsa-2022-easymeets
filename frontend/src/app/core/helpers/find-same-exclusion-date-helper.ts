import { DatesEqualComparator } from '@core/helpers/dates-equal-comparator-helper';
import { IExclusionDate } from '@core/models/schedule/exclusion-date/IExclusionDate';

export const FindSameExclusionDateHelper = (dates: IExclusionDate[], dateToFind: IExclusionDate) =>
    dates.find((date) =>
        DatesEqualComparator(dateToFind.selectedDate, new Date(date.selectedDate)));
