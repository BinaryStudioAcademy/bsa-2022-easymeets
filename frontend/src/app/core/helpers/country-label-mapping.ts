import { Country } from '@shared/enums/country';

export function CountryLabelMapping(country: Country): string {
    switch (country) {
        case Country.UnitedStates:
            return 'United States';
        default:
            return country;
    }
}
