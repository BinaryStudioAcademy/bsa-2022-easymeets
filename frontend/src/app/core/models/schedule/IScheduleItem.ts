export interface IScheduleItem {
    id?: bigint;
    start: string;
    end: string;
    weekDay: number;
    isEnabled: boolean;
}
