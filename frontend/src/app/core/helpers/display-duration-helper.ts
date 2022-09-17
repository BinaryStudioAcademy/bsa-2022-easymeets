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

export const getDefaultInputSettings = (): IInputSettings[] => [
    {
        durationValue: getDisplayDuration()[0],
        inputType: InputFieldType.Duration,
        isCustom: false,
        inputValue: '',
    },
    {
        durationValue: getDisplayDuration()[0],
        inputType: InputFieldType.Frequency,
        isCustom: false,
        inputValue: '',
    },
    {
        durationValue: getDisplayDuration()[0],
        inputType: InputFieldType.Padding,
        isCustom: false,
        inputValue: '',
    },
    {
        durationValue: getDisplayDuration()[0],
        inputType: InputFieldType.MinBookTime,
        isCustom: false,
        inputValue: '',
    },
];
