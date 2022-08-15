import { EventEmitter } from '@angular/core';

export interface IConfirmButtonOptions {
    class: string;
    label: string;
    onClickEvent: EventEmitter<void>;
}
