import { IConfirmButtonOptions } from '@core/models/IConfirmButtonOptions';

export interface IConfirmDialogData {
    title: string;

    message: string;

    acceptButton?: IConfirmButtonOptions;

    cancelButton?: IConfirmButtonOptions;
}
