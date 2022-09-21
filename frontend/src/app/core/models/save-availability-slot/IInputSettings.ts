import { InputFieldType } from '@shared/enums/custom-field';

import { IDuration } from '../IDuration';

export interface IInputSettings {
    durationValue?: IDuration;
    inputType: InputFieldType;
    isCustom: boolean;
    inputValue: string;
}
