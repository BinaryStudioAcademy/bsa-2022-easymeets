import { IDuration } from '@core/models/IDuration';
import { IInputSettings } from '@core/models/save-availability-slot/IInputSettings';
import { InputFieldType } from '@shared/enums/custom-field';
import { UnitOfTime } from '@shared/enums/unitOfTime';

export const getDisplayDuration = (): IDuration[] => [
    { time: '15', unitOfTime: UnitOfTime.Min, minutes: 15 },
    { time: '30', unitOfTime: UnitOfTime.Min, minutes: 30 },
    { time: '45', unitOfTime: UnitOfTime.Min, minutes: 45 },
    { time: '1', unitOfTime: UnitOfTime.Hour, minutes: 60 },
    { time: 'Custom' },
];

export const getInputSettings = (): { [type: string]: IInputSettings } => {
    const inputValues: { [type: string]: IInputSettings } = {};

    inputValues[InputFieldType.Duration] = {
        durationValue: getDisplayDuration()[0],
        inputType: InputFieldType.Duration,
        isCustom: false,
        inputValue: '',
    };

    inputValues[InputFieldType.Frequency] = {
        durationValue: getDisplayDuration()[0],
        inputType: InputFieldType.Frequency,
        isCustom: false,
        inputValue: '',
    };

    inputValues[InputFieldType.Padding] = {
        durationValue: getDisplayDuration()[0],
        inputType: InputFieldType.Padding,
        isCustom: false,
        inputValue: '',
    };

    inputValues[InputFieldType.MinBookTime] = {
        durationValue: getDisplayDuration()[0],
        inputType: InputFieldType.MinBookTime,
        isCustom: false,
        inputValue: '',
    };

    return inputValues;
};
