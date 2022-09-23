import { Component, Input } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { BaseComponent } from '@core/base/base.component';
import { IUserMeeting } from '@core/models/IUserMeeting';

import { ExternalAttendeeAnswersComponent } from '../external-attendee-answers/external-attendee-answers.component';

@Component({
    selector: 'app-booker',
    templateUrl: './booker.component.html',
    styleUrls: ['./booker.component.sass'],
})
export class BookerComponent extends BaseComponent {
    @Input() public booker: IUserMeeting;

    constructor(private dialog: MatDialog) {
        super();
    }

    showAnswersWindow() {
        if (!this.getAnsweredQuestions().length) {
            return;
        }
        this.dialog
            .open(ExternalAttendeeAnswersComponent, { data: {
                booker: this.booker,
                questions: this.getAnsweredQuestions(),
            } })
            .afterClosed()
            .subscribe(() => {});
    }

    getAnsweredQuestions() {
        return this.booker.questions.filter(q => q.answer);
    }
}
