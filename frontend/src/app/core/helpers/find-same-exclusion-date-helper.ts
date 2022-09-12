import { datesEqual } from '@core/helpers/date-helper';
import { IExclusionDate } from '@core/models/schedule/exclusion-date/IExclusionDate';

export const FindSameExclusionDateHelper = (dates: IExclusionDate[], dateToFind: IExclusionDate) => {
    const dateToFindSelected = new Date(dateToFind.selectedDate);

    return dates.find((date) => {
        const selectedDate = new Date(date.selectedDate);

        return datesEqual(dateToFindSelected, selectedDate);
    });
};
