import { Component, OnInit } from '@angular/core';
import { IExternalAnswers } from '@core/models/IExternalAnswers';

@Component({
    selector: 'app-external-booking-confirm-page',
    templateUrl: './external-booking-confirm-page.component.html',
    styleUrls: ['./external-booking-confirm-page.component.sass'],
})
export class ExternalBookingConfirmPageComponent implements OnInit {
    // eslint-disable-next-line @typescript-eslint/no-useless-constructor, no-empty-function, @typescript-eslint/no-empty-function
    constructor() {}

    ngOnInit(): void {
        this.externalAnswers = {
            externalName: '',
            externalEmail: '',
            externalExtraInfo: '',
        };
    }

    public externalAnswers: IExternalAnswers;
}
