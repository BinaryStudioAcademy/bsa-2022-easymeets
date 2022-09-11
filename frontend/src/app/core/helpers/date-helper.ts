export const addMinutesHelper = (date: Date | string, minutes: number) =>
    new Date(new Date(date).getTime() + minutes * 60000);
