import { Injectable } from '@angular/core';
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
        return this.httpService.getRequest<INewMeetingTeamMember[]>(`${this.routePrefix}`);
    }
}
