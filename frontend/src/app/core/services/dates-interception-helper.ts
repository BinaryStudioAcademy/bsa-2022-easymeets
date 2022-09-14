export const isBetweenDates = (moment: Date, periodStart: Date, periodEnd: Date, strict?: boolean) => {
    if (!strict) {
        return moment >= periodStart && moment <= periodEnd;
    }

    return moment > periodStart && moment < periodEnd;
};
