import { Component, OnInit } from '@angular/core';
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
export class EditMeetingComponent extends BaseComponent implements OnInit {
    meeting: IMeeting;

    constructor(
        private activateRoute: ActivatedRoute,
        private spinnerService: SpinnerService,
        private http: NewMeetingService,
    ) {
        super();
    }

    ngOnInit(): void {
        const meetingId = BigInt(this.activateRoute.snapshot.paramMap.get('id') ?? '');

        this.spinnerService.show();

        this.http
            .getMeetingById(meetingId)
            .pipe(this.untilThis)
            .subscribe((meeting) => {
                this.meeting = meeting;

                this.spinnerService.hide();
            });
    }
}
