import { Injectable } from '@angular/core';
import { IMeetingBooking } from '@core/models/IMeetingBooking';
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

    public getThreeMeetings(currentTeamId?: number): Observable<IMeetingBooking[]> {
        return this.httpService.getRequest<IMeetingBooking[]>(`${this.routePrefix}/getThreeMeetingMembers/${currentTeamId ?? ''}`);
    }

    public getAllMembers(id: number) {
        return this.httpService.getRequest<IUserMeeting[]>(`${this.routePrefix}/${id}/members/all`);
    }
}
