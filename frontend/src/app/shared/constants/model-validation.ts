export const userNameRegex: string | RegExp = new RegExp('^[a-zA-Zа-яА-Я0-9- ]+$');
export const meetingNameRegex = "^([A-Za-z0-9-']+\\s)*[A-Za-z0-9-']+$";
export const naturalNumberRegex = '^[1-9][0-9]*$';
export const timeNumberRegex = '\\d{2}:\\d{2}';
export const hourMinutesRegex = '^([0-1]?[0-9]|2[0-3]):[0-5][0-9]$';
export const nameWithoutSpaces = '^[^\\s]+(\\s+[^\\s]+)*$';
