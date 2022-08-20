import { Component } from '@angular/core';
import { NewMeetingService } from '@core/services/new-meeting.service';

@Component({
    selector: 'app-new-meeting',
    templateUrl: './new-meeting.component.html',
    styleUrls: ['./new-meeting.component.sass'],
})
export class NewMeetingComponent {
    // eslint-disable-next-line no-unused-vars
    constructor(private newMeetingService: NewMeetingService) {
        this.getTeamMembersOfCurrentUser();
    }

    public getTeamMembersOfCurrentUser() {
        this.newMeetingService
            .getTeamMembersOfCurrentUser()
            .subscribe((resp) => {
                console.log(resp);
            });
    }
}
