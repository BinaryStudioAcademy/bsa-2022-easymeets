import { IExclusionDate } from '@core/models/schedule/exclusion-date/IExclusionDate';

export const FindSameExclusionDateHelper = (dates: IExclusionDate[], dateToFind: IExclusionDate) =>
    dates.find((date) => {
        const selectedDate = new Date(date.selectedDate);

        return (
            dateToFind.selectedDate.getDate() === selectedDate.getDate() &&
            dateToFind.selectedDate.getMonth() === selectedDate.getMonth() &&
            dateToFind.selectedDate.getFullYear() === selectedDate.getFullYear()
        );
    });
