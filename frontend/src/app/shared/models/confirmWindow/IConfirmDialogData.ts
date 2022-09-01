import { Type } from '@angular/core';
import { IConfirmButtonOptions } from '@shared/models/confirmWindow/IConfirmButtonOptions';

export interface IConfirmDialogData {
    title: string;
    message?: string;
    buttonsOptions: IConfirmButtonOptions[];
    titleImagePath?: string;
    component?: Type<any>;
}
