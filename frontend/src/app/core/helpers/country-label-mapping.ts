import { Country } from '@shared/enums/country';

export function CountryLabelMapping(country: Country | string): string {
    switch (country) {
        case Country.UnitedStates:
        case 'UnitedStates':
            return 'United States';
        default:
            return country;
    }
}
