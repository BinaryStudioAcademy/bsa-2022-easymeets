import { CdkDragDrop, moveItemInArray } from '@angular/cdk/drag-drop';
import { Component, Input } from '@angular/core';
import { FormControl } from '@angular/forms';
import { getLocalMandatoryQuestions } from '@core/helpers/questions-mandatory-helper';
import { removeExcessiveSpaces } from '@core/helpers/string-helper';
import { IAvailabilitySlot } from '@core/models/IAvailabilitySlot';
import { IQuestion } from '@core/models/IQuestion';
import { textFieldRegex } from '@shared/constants/model-validation';
import { invalidCharactersMessage } from '@shared/constants/shared-messages';

@Component({
    selector: 'app-questions',
    templateUrl: './questions.component.html',
    styleUrls: ['./questions.component.sass'],
})
export class QuestionsComponent {
    @Input() set newSlot(slot: IAvailabilitySlot | undefined) {
        this.questions = slot?.questions ?? getLocalMandatoryQuestions();
        this.mandatoryQuestions = this.questions.filter((q) => q.isMandatory);
        const biggestOrderInQuestions = Math.max(...this.questions.map((q) => q.order));

        this.newQuestionOrder = biggestOrderInQuestions + 1;
        this.onQuestionsArrayChange();
    }

    public questions: IQuestion[] = [];

    public optionalQuestionsExist: boolean = false;

    public mandatoryQuestionsExist: boolean = false;

    public textFieldRegex = textFieldRegex;

    public invalidCharactersMessage = invalidCharactersMessage;

    private mandatoryQuestions: IQuestion[] = [];

    private newQuestionOrder: number = 0;

    private onQuestionsArrayChange(): void {
        this.mandatoryQuestionsExist = this.questions.some((q) => q.isMandatory);
        this.optionalQuestionsExist = this.questions.some((q) => !q.isMandatory);
    }

    public addNewQuestion(): void {
        this.questions = [
            ...this.questions,
            {
                id: 0,
                order: this.newQuestionOrder++,
                questionText: '',
                placeHolderText: '',
                isMandatory: false,
            },
        ];
        this.onQuestionsArrayChange();
    }

    public deleteQuestion(questionOrder: number): void {
        this.questions = this.questions.filter((q) => q.order !== questionOrder);
        this.onQuestionsArrayChange();
    }

    public drop(event: CdkDragDrop<unknown>): void {
        const offset: number = this.mandatoryQuestions.length;

        moveItemInArray(this.questions, event.previousIndex + offset, event.currentIndex + offset);
    }

    public move(currentIndex: number, isDown: boolean): void {
        const toIndex = isDown ? currentIndex + 1 : currentIndex - 1;

        if (currentIndex === this.mandatoryQuestions.length && !isDown) {
            return;
        }
        moveItemInArray(this.questions, currentIndex, toIndex);
    }

    public trimInputValue(control: FormControl) {
        control.patchValue(removeExcessiveSpaces(control.value));
    }
}
