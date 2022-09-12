export const userNameRegex = new RegExp('^[\\p{L}\\s0-9- ]*$', 'um');
export const naturalNumberRegex = '^[1-9][0-9]*$';
export const timeNumberRegex = '\\d{2}:\\d{2}';
export const hourMinutesRegex = '^([0-1]?[0-9]|2[0-3]):[0-5][0-9]$';
export const nameWithoutSpaces = '^[^\\s]+(\\s+[^\\s]+)*$';
export const emailRegex =
    '^([a-zA-z0-9]+([._\\-][a-zA-z0-9]+)?)+@([a-zA-z0-9]+([.\\-][a-zA-Z0-9]+)?)+\\.[a-zA-Z]{2,4}$';
export const textFieldRegex = new RegExp(
    '^[\\p{L}\\s0-9"\\(\\),:;<>@\\[\\\\\\]!#\\$%&\'\\*\\+-\\/=\\?\\^_`\\{\\|\\]\\*]*$',
    'u',
);
