import { IConfirmButtonOptions } from './IConfirmButtonOptions';

export interface IConfirmDialogData {
    title: string;
    message: string;
    acceptButton?: IConfirmButtonOptions;
    cancelButton?: IConfirmButtonOptions;
}
