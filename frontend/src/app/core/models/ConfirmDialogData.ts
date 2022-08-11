import { ConfirmButtonOptions } from '@core/models/ConfirmButtonOptions';

export interface ConfirmDialogData {
    title: string;

    message: string;

    acceptButton?: ConfirmButtonOptions;

    cancelButton?: ConfirmButtonOptions;
}
