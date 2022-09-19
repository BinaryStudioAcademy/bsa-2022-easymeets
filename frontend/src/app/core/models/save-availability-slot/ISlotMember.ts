import { ISchedule } from '@core/models/schedule/ISchedule';

export interface ISlotMember {
    priority: number;
    memberId?: bigint;
    name?: string;
    email?: string;
    image?: string;
    schedule?: ISchedule;
}
