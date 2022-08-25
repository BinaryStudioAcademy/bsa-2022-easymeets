import { CdkDragDrop, moveItemInArray } from '@angular/cdk/drag-drop';
import { Component, Input } from '@angular/core';
import { IAvailabilitySlot } from '@core/models/IAvailiabilitySlot';
import { IQuestion } from '@core/models/IQuestion';

const tempMandatoryQuestions: IQuestion[] = [
    { text: 'Name', isMandatory: true },
    { text: 'Email', isMandatory: true },
];

@Component({
    selector: 'app-questions',
    templateUrl: './questions.component.html',
    styleUrls: ['./questions.component.sass'],
})
export class QuestionsComponent {
    @Input() set newSlot(slot: IAvailabilitySlot | undefined) {
        this.questions = slot?.questions ?? tempMandatoryQuestions;
        this.mandatoryQuestions = this.questions.filter((q) => q.isMandatory);
        this.onQuestionsArrayChange();
    }

    public questions: IQuestion[] = [];

    private mandatoryQuestions: IQuestion[] = [];

    public optionalQuestionsExist: boolean = false;

    public mandatoryQuestionsExist: boolean = false;

    private onQuestionsArrayChange(): void {
        this.mandatoryQuestionsExist = this.questions.some((q) => q.isMandatory);
        this.optionalQuestionsExist = this.questions.some((q) => !q.isMandatory);
    }

    public addNewQuestion(): void {
        this.questions.push({ text: '', isMandatory: false });
        this.onQuestionsArrayChange();
    }

    public deleteQuestion(question: IQuestion): void {
        const index: number = this.questions.indexOf(question, 0);

        if (index > -1) {
            this.questions.splice(index, 1);
        }
        this.onQuestionsArrayChange();
    }

    public drop(event: CdkDragDrop<unknown>): void {
        const offset: number = this.mandatoryQuestions.length;

        moveItemInArray(this.questions, event.previousIndex + offset, event.currentIndex + offset);
    }
}
