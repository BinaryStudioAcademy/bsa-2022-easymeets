import { Component, Inject } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { addMinutesHelper } from '@core/helpers/date-helper';
import { removeExcessiveSpaces } from '@core/helpers/string-helper';
import { IUserMeeting } from '@core/models/IUserMeeting';
import { textFieldRegex } from '@shared/constants/model-validation';
import { IConfirmDialogData } from '@shared/models/confirmWindow/IConfirmDialogData';

@Component({
    selector: 'app-external-attendee-answers',
    templateUrl: './external-attendee-answers.component.html',
    styleUrls: ['./external-attendee-answers.component.sass'],
})
export class ExternalAttendeeAnswersComponent {
    public textFieldRegex = textFieldRegex;

    public booker: IUserMeeting;

    public endMeetingTime: Date;

    constructor(
        @Inject(MAT_DIALOG_DATA) public data: IConfirmDialogData,
        private dialogRef: MatDialogRef<ExternalAttendeeAnswersComponent>,
    ) {
        this.booker = data as unknown as IUserMeeting;
        this.endMeetingTime = addMinutesHelper(this.booker.meetingDate, this.booker.meetingDuration);
    }

    clickApply() {
        this.dialogRef.close();
    }

    clickCancel() {
        this.dialogRef.close();
    }

    public trimInputValue(control: FormControl) {
        control.patchValue(removeExcessiveSpaces(control.value));
    }
}
