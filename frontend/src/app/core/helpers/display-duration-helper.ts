import { IDuration } from '@core/models/IDuration';
import { UnitOfTime } from '@shared/enums/unitOfTime';

export const getDisplayDuration = (): IDuration[] => [
    { time: '15', unitOfTime: UnitOfTime.Min, minutes: 15 },
    { time: '30', unitOfTime: UnitOfTime.Min, minutes: 30 },
    { time: '45', unitOfTime: UnitOfTime.Min, minutes: 45 },
    { time: '1', unitOfTime: UnitOfTime.Hour, minutes: 60 },
    { time: 'Custom' },
];
