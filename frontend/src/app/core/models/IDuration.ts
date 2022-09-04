import { UnitOfTime } from '@shared/enums/unitOfTime';

export interface IDuration {
    time: string;
    unitOfTime?: UnitOfTime;
    minutes?: number;
}
