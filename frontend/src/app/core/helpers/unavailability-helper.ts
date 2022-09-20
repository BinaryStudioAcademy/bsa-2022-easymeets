import { isBetweenDates } from '@core/helpers/date-helper';
import { IUnavailability } from '@core/models/IUnavailability';
import { addMinutes } from 'date-fns';

import { applyTimeZoneToDate, getDefaultTimeZone } from './time-zone-helper';

export const applyDefaultTimeZone = (events: IUnavailability[]) => {
    const defaultTimeZone = getDefaultTimeZone();

    return events.map(
        (e) =>
            ({
                start: applyTimeZoneToDate(new Date(e.start), defaultTimeZone, true),
                end: applyTimeZoneToDate(new Date(e.end), defaultTimeZone, true),
            } as IUnavailability),
    );
};

export const removeFinished = (events: IUnavailability[]) => events.filter((e) => e.end > new Date());

export const shortenStarted = (events: IUnavailability[]) =>
    events.map((e) => {
        if (e.start < new Date()) {
            return { ...e, start: addMinutes(new Date(), 1) };
        }

        return e;
    });

export const isUnavailable = (
    periodStart: Date,
    periodEnd: Date,
    unavailability: IUnavailability,
    restrictTouch: boolean = true,
) =>
    isBetweenDates(periodEnd, unavailability.start, unavailability.end, restrictTouch) ||
    isBetweenDates(unavailability.end, periodStart, periodEnd, restrictTouch);

export const getInterceptingEvents = (events: IUnavailability[], unavailability: IUnavailability) =>
    events.filter((e) => isUnavailable(e.start, e.end, unavailability, false));

export const getEarliestStart = (events: IUnavailability[]) =>
    events.reduce((p, c) => (p.start < c.start ? p : c)).start;

export const getLatestEnd = (events: IUnavailability[]) => events.reduce((p, c) => (p.end > c.end ? p : c)).end;

export const mergeEvents = (events: IUnavailability[]): IUnavailability => ({
    start: getEarliestStart(events),
    end: getLatestEnd(events),
});

export const mergeUnavailabilities = (events: IUnavailability[]) => {
    let merged: IUnavailability[] = [];

    events.forEach((value, index, array) => {
        const currentIntercepting = getInterceptingEvents(array, value);

        const mergedEvent = mergeEvents(currentIntercepting);

        const conflicts = getInterceptingEvents(merged, mergedEvent);

        merged = merged
            .filter((e) => !conflicts.some((c) => c.start === e.start && c.end === e.end))
            .concat(mergeEvents([...conflicts, mergedEvent]));
    });

    return merged;
};
