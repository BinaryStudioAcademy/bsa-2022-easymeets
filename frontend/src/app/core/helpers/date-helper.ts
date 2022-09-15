export const addMinutesHelper = (date: Date | string, minutes: number) =>
    new Date(new Date(date).getTime() + minutes * 60000);

export const datesEqual = (firstDate: Date, secondDate: Date) =>
    firstDate.getDate() === secondDate.getDate() &&
    firstDate.getMonth() === secondDate.getMonth() &&
    firstDate.getFullYear() === secondDate.getFullYear();

export const isBetweenDates = (moment: Date, periodStart: Date, periodEnd: Date, strict?: boolean) => {
    if (!strict) {
        return moment >= periodStart && moment <= periodEnd;
    }

    return moment > periodStart && moment <= periodEnd;
};
