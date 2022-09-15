import { IConfirmButtonOptions } from './IConfirmButtonOptions';

export interface ISlotPasswordData {
    title: string;
    message?: string;
    buttonsOptions?: IConfirmButtonOptions[];
    slotLink: string;
}
