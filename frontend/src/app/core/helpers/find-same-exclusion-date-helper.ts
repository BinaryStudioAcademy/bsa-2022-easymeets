import { IExclusionDate } from '@core/models/schedule/exclusion-date/IExclusionDate';

export const FindSameExclusionDateHelper = (dates: IExclusionDate[], dateToFind: IExclusionDate) =>
    dates.find(
        (date) =>
            dateToFind.selectedDate.getDate() === date.selectedDate.getDate() &&
            dateToFind.selectedDate.getMonth() === date.selectedDate.getMonth() &&
            dateToFind.selectedDate.getFullYear() === date.selectedDate.getFullYear(),
    );
