import { Injectable } from '@angular/core';
import { INewMeeting } from '@core/models/INewMeeting';
import { INewMeetingTeamMember } from '@core/models/INewMeetingTeamMember';

import { HttpInternalService } from './http-internal.service';

@Injectable({
    providedIn: 'root',
})
export class NewMeetingService {
    public routePrefix = '/meeting';

    // eslint-disable-next-line no-empty-function
    constructor(private httpService: HttpInternalService) {}

    public getTeamMembersOfCurrentUser() {
        return this.httpService.getRequest<INewMeetingTeamMember[]>(`${this.routePrefix}/getTeamMembersOfCurrentUser`);
    }

    public saveNewMeeting(data: INewMeeting) {
        return this.httpService.postRequest(`${this.routePrefix}`, data);
    }
}
