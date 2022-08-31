import { LocationType } from '@shared/enums/locationType';

export function LocationTypeMapping(locationType: LocationType | string): string {
    switch (locationType) {
        case LocationType.GoogleMeet:
        case 'GoogleMeet':
            return 'Google Meet';
        default:
            return locationType;
    }
}
