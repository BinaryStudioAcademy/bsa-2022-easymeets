export interface IScheduleItemReceive {
    id?: bigint;
    start: Date;
    end: Date;
    weekDay: number;
    isEnabled: boolean;
}
