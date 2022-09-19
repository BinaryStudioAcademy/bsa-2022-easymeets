import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormControl } from '@angular/forms';
import { BaseComponent } from '@core/base/base.component';
import {
    userEmailPlaceHolder,
    userEmailQuestionText,
    userFullNamePlaceHolder,
    userFullNameQuestionText,
} from '@core/helpers/questions-mandatory-helper';
import { removeExcessiveSpaces } from '@core/helpers/string-helper';
import { IQuestion } from '@core/models/IQuestion';
import { emailRegex, textFieldRegex } from '@shared/constants/model-validation';

@Component({
    selector: 'app-external-booking-confirm-page',
    templateUrl: './external-booking-confirm-page.component.html',
    styleUrls: ['./external-booking-confirm-page.component.sass'],
})
export class ExternalBookingConfirmPageComponent extends BaseComponent implements OnInit {
    @Output() confirmBooking = new EventEmitter<IQuestion[]>();

    @Output() cancelBooking = new EventEmitter<boolean>();

    @Input() questions: IQuestion[];

    public textFieldRegex = textFieldRegex;

    public emailPattern = emailRegex;

    public fullNameText = userFullNameQuestionText;

    public fullNamePlaceHolder = userFullNamePlaceHolder;

    public emailText = userEmailQuestionText;

    public emailPlaceHolder = userEmailPlaceHolder;

    public additionalQuestions: IQuestion[];

    ngOnInit(): void {
        this.getAdditionalQuestion(this.questions);
    }

    OnConfirmBooking() {
        this.addAnswers();
        this.confirmBooking.emit(this.questions);
    }

    public trimInputValue(control: FormControl) {
        control.patchValue(removeExcessiveSpaces(control.value));
    }

    private getAdditionalQuestion(questions: IQuestion[]) {
        this.additionalQuestions = questions.filter((x) => !x.isMandatory);
    }

    private addAnswers() {
        this.questions.forEach((question) => {
            if (!question.isMandatory) {
                question.answer = this.additionalQuestions.find((x) => x.questionText === question.questionText)
                    ?.answer as string;
            }
        });
    }
}
