import { ITimeZone } from '@core/models/ITimeZone';

export const TimeZoneFullNameMapper = (fullTimeZoneName: string): ITimeZone => ({
    nameValue: fullTimeZoneName.substring(0, fullTimeZoneName.length - 9),
    timeValue: fullTimeZoneName.substring(fullTimeZoneName.length - 7, fullTimeZoneName.length - 1),
});
