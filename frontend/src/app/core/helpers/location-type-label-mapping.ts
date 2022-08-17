import { LocationType } from '@core/models/locationType';

export const LocationTypeToLabelMapping: Record<LocationType, string> = {
    [LocationType.Zoom]: 'Zoom',
    [LocationType.GoogleMeet]: 'Google Meet',
    [LocationType.Office]: 'Office',
};
