import { CountryCode } from '@core/helpers/countryCode';

export const removePhoneNumberCodeHelper = (phone: string | undefined) => {
    if (!phone) {
        return phone;
    }
    let newPhone = phone;

    if (newPhone.startsWith('+')) {
        newPhone = newPhone.substring(1);
    }
    const phoneCode = Object.values(CountryCode).find(code => newPhone.startsWith(code));

    return phoneCode
        ? newPhone.substring(phoneCode.length)
        : newPhone;
};
