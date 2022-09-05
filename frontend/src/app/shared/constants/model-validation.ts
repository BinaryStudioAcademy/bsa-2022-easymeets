export const userNameRegex: string | RegExp = new RegExp('^[a-zA-Zа-яА-Я0-9- ]+$');
export const meetingNameRegex = "^([A-Za-z0-9-']+\\s)*[A-Za-z0-9-']+$";
export const newMeetingNameRegex = '^([єЄіІїЇa-zA-Z\\dа-яА-Я-]+(\\s|))*$';
export const naturalNumberRegex = '^[1-9][0-9]*$';
export const timeNumberRegex = '\\d{2}:\\d{2}';
export const hourMinutesRegex = '^([0-1]?[0-9]|2[0-3]):[0-5][0-9]$';
export const nameWithoutSpaces = '^[^\\s]+(\\s+[^\\s]+)*$';
export const emailRegex = '^([a-zA-z0-9]+([._\\-][a-zA-z0-9]+)?)+@([a-zA-z0-9]+([.\\-][a-zA-Z0-9]+)?)+\\.[a-zA-Z]{2,4}$';
