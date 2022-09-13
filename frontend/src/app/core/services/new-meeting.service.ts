import { Injectable } from '@angular/core';
import { INewMeeting } from '@core/models/INewMeeting';
import { INewMeetingMember } from '@core/models/INewMeetingTeamMember';
import { IOrderedMeetingTimes } from '@core/models/IOrderedMeetingTimes';

import { HttpInternalService } from './http-internal.service';

@Injectable({
    providedIn: 'root',
})
export class NewMeetingService {
    public routePrefix = '/meeting';

    // eslint-disable-next-line no-empty-function
    constructor(private httpService: HttpInternalService) {}

    public getTeamMembersOfCurrentUserByName(name: string, teamId?: number) {
        return this.httpService.getRequest<INewMeetingMember[]>(
            `${this.routePrefix}/getTeamMembersOfCurrentUser/${name}/${teamId ?? ''}`,
        );
    }

    public saveNewMeeting(data: INewMeeting) {
        return this.httpService.postRequest<INewMeeting>(`${this.routePrefix}`, data);
    }

    public getOrderedMeetingTimes(slotId: bigint) {
        return this.httpService.getRequest<IOrderedMeetingTimes[]>(`${this.routePrefix}/ordered-times/${slotId}`);
    }
}
