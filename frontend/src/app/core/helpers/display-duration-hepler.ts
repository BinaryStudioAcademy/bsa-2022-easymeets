import { IDuration } from '@core/models/IDuration';

export const getDisplayDuration = (): IDuration[] => [
    { time: '15', unitOfTime: 'min' },
    { time: '30', unitOfTime: 'min' },
    { time: '45', unitOfTime: 'min' },
    { time: '1', unitOfTime: 'hour' },
    { time: 'Custom', unitOfTime: '' }];
