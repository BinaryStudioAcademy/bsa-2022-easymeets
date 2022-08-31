import { LocationType } from '@shared/enums/locationType';

export function LocationTypeMapping(locationType: LocationType): string {
    switch (locationType) {
        case LocationType.GoogleMeet:
            return 'Google Meet';
        default:
            return locationType;
    }
}
