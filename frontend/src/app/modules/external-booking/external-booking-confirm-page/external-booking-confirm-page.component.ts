import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { IExternalAnswers } from '@core/models/IExternalAnswers';
import { nameWithoutSpaces, userNameRegex } from '@shared/constants/model-validation';

@Component({
    selector: 'app-external-booking-confirm-page',
    templateUrl: './external-booking-confirm-page.component.html',
    styleUrls: ['./external-booking-confirm-page.component.sass'],
})
export class ExternalBookingConfirmPageComponent implements OnInit {
    ngOnInit(): void {
        this.externalAnswers = {
            externalName: '',
            externalEmail: '',
            externalExtraInfo: '',
        };
    }

    public confirmForm = new FormGroup({
        characters: new FormControl('', [
            Validators.pattern(userNameRegex), Validators.pattern(nameWithoutSpaces),
            Validators.minLength(2),
            Validators.maxLength(50),
        ]),
        email: new FormControl('', [Validators.email]),
        extraInfo: new FormControl('', [Validators.minLength(3), Validators.maxLength(80)]),
    });

    get characters() {
        return this.confirmForm.get('characters');
    }

    get email() {
        return this.confirmForm.get('email');
    }

    get extraInfo() {
        return this.confirmForm.get('extraInfo');
    }

    public externalAnswers: IExternalAnswers;
}
