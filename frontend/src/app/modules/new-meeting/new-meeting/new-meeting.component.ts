import { Component } from '@angular/core';
import { getDisplayDate } from '@core/helpers/date-helper';
import { getDisplayDuration } from '@core/helpers/display-duration-hepler';
import { INewMeetingTeamMember } from '@core/models/INewMeetingTeamMember';
import { NewMeetingService } from '@core/services/new-meeting.service';

@Component({
    selector: 'app-new-meeting',
    templateUrl: './new-meeting.component.html',
    styleUrls: ['./new-meeting.component.sass'],
})
export class NewMeetingComponent {
    public teamMembers: INewMeetingTeamMember[];

    public durations = getDisplayDuration();

    public dates = getDisplayDate();

    // eslint-disable-next-line no-unused-vars
    constructor(private newMeetingService: NewMeetingService) {
        this.getTeamMembersOfCurrentUser();
    }

    public getTeamMembersOfCurrentUser() {
        this.newMeetingService
            .getTeamMembersOfCurrentUser()
            .subscribe((resp) => {
                this.teamMembers = resp;
            });
    }

    public searchMember(value: string) {
        const filter = value.toLowerCase();

        return this.teamMembers.filter(option => option.name.toLowerCase().startsWith(filter));
    }
}
