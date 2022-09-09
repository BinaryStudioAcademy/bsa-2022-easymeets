import { Injectable } from '@angular/core';
import { IMeetingBooking } from '@core/models/IMeetingBooking';
import { IMeetingMembersRequest } from '@core/models/IMeetingMemberRequest';
import { IUserMeeting } from '@core/models/IUserMeeting';
import { Observable } from 'rxjs';

import { HttpInternalService } from './http-internal.service';

@Injectable({
    providedIn: 'root',
})
export class MeetingBookingsService {
    public routePrefix = '/meeting';

    // eslint-disable-next-line no-empty-function
    constructor(private httpService: HttpInternalService) {}

    public getThreeMeetings(data: IMeetingMembersRequest): Observable<IMeetingBooking[]> {
        return this.httpService.postRequest<IMeetingBooking[]>(`${this.routePrefix}/getThreeMeetingMembers`, data);
    }

    public getAllMembers(id: number) {
        return this.httpService.getRequest<IUserMeeting[]>(`${this.routePrefix}/${id}/members/all`);
    }

    public deleteBooking(id: number) {
        return this.httpService.deleteRequest<IUserMeeting[]>(`${this.routePrefix}/${id}`);
    }
}
