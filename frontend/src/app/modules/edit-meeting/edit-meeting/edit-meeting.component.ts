import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { IMeeting } from '@core/models/IMeeting';
import { NewMeetingService } from '@core/services/new-meeting.service';
import { SpinnerService } from '@core/services/spinner.service';

@Component({
    selector: 'app-edit-meeting',
    templateUrl: './edit-meeting.component.html',
    styleUrls: ['./edit-meeting.component.sass'],
})
export class EditMeetingComponent extends BaseComponent {
    meeting: IMeeting;

    constructor(
        private activateRoute: ActivatedRoute,
        private spinnerService: SpinnerService,
        private http: NewMeetingService,
    ) {
        super();
        this.activateRoute.params.pipe(this.untilThis).subscribe((params) => {
            this.spinnerService.show();
            this.http
                .getMeetingById(params['id'])
                .pipe(this.untilThis)
                .subscribe((meeting) => {
                    this.meeting = meeting;

                    this.spinnerService.hide();
                });
        });
    }
}
